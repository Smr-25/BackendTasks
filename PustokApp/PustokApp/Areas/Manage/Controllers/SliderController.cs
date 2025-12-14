using Microsoft.AspNetCore.Mvc;
using Pustok.Data;
using Pustok.Extensions;
using Pustok.Models;

namespace Pustok.Areas.Manage.Controllers;

[Area("Manage")]
public class SliderController(AppDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        var sliders = dbContext.Sliders.ToList();
        return View(sliders);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Slider slider)
    {
        if (!ModelState.IsValid)
            return View();
        if (slider.ImageFile == null)
        {
            ModelState.AddModelError("ImageFile", "File type must be image");
            return View();
        }
        if (slider.ImageFile.CheckFileType())
        {
            ModelState.AddModelError("ImageFile", "File type must be image");
            return View();
        }

        if (slider.ImageFile.CheckFileSize(2))
        {
            ModelState.AddModelError("ImageFile", "Image size must be max 2MB");
            return View();
        }

        if (slider.ImageFile != null)
        {
            slider.ImageUrl = slider.ImageFile.SaveFile("wwwroot/assets/image/bg-images");
        }

        dbContext.Sliders.Add(slider);
        dbContext.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var slider = dbContext.Sliders.Find(id);
        if (slider == null) return NotFound();
        dbContext.Sliders.Remove(slider);
        dbContext.SaveChanges();
        
        if (!string.IsNullOrEmpty(slider.ImageUrl))
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/image/bg-images", slider.ImageUrl);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        return Ok();
    }

    public IActionResult Update(int id)
    {
        var slider = dbContext.Sliders.Find(id);
        if (slider == null) return NotFound();
        return View(slider);
    }

    [HttpPost]
    public IActionResult Update(Slider slider)
    {
        if (!ModelState.IsValid)
            return View(slider);
        var existSlider = dbContext.Sliders.Find(slider.Id);
        if (existSlider == null) return NotFound();
        
        if (slider.ImageFile != null)
        {
            if (slider.ImageFile.CheckFileType())
            {
                ModelState.AddModelError("ImageFile", "File type must be image");
                return View(slider);
            }

            if (slider.ImageFile.CheckFileSize(2))
            {
                ModelState.AddModelError("ImageFile", "Image size must be max 2MB");
                return View(slider);
            }
            
            // Köhnə şəkili sil
            if (!string.IsNullOrEmpty(existSlider.ImageUrl))
            {
                string oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/image/bg-images", existSlider.ImageUrl);
                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }
            }
            
            // Yeni şəkili yüklə
            existSlider.ImageUrl = slider.ImageFile.SaveFile("wwwroot/assets/image/bg-images");
        }
        
        existSlider.Title = slider.Title;
        existSlider.Description = slider.Description;
        existSlider.ButtonText = slider.ButtonText;
        existSlider.ButtonUrl = slider.ButtonUrl;
        existSlider.Order = slider.Order;
        
        dbContext.SaveChanges();
        return RedirectToAction("Index");

    }
}