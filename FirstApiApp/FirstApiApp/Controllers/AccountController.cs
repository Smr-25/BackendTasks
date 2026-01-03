using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using FirstApiApp.Dtos.Users;
using FirstApiApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FirstApiApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper,IConfiguration configuration)
    : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterDto userRegisterDto)
    {
        var existingUser = await userManager.FindByNameAsync(userRegisterDto.UserName);
        if (existingUser != null)
        {
            return BadRequest("Username is already taken.");
        }

        var user = mapper.Map<AppUser>(userRegisterDto);
        var result = await userManager.CreateAsync(user, userRegisterDto.Password);
        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        await userManager.AddToRoleAsync(user, "User");
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserLoginDto userLoginDto)
    {
        var user = await userManager.FindByNameAsync(userLoginDto.UserName);
        if (user == null)
        {
            return Unauthorized("Invalid username or password.");
        }

        var isPasswordValid = await userManager.CheckPasswordAsync(user, userLoginDto.Password);
        if (!isPasswordValid)
            return Unauthorized("Invalid username or password.");

        var roles = await userManager.GetRolesAsync(user);
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim("FullName", user.FullName)
        };
        
        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetSection("JwtSettings:SecretKey").Value));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            issuer: configuration.GetSection("JwtSettings:Issuer").Value,
            audience: configuration.GetSection("JwtSettings:Audience").Value,
            claims: claims,
            expires: DateTime.Now.AddMinutes(30),
            signingCredentials: creds
        );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
        
        return Ok(tokenString);
    }
}