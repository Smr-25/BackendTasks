using System.Text.Json;
using StackExchange.Redis;

namespace MenuApp.Services;

public class RedisService(IConnectionMultiplexer connectionMultiplexer) : IRedisService
{
    private readonly IDatabase _database = connectionMultiplexer.GetDatabase();

    public async Task SetValueAsync<T>(string key, T data, TimeSpan? expiry = null)
    {
        var jsonData = JsonSerializer.Serialize(data);
        if (expiry.HasValue)
            await _database.StringSetAsync(key, jsonData, expiry.Value);
        else
            await _database.StringSetAsync(key, jsonData);
    }
    
    public async Task<T?> GetValueAsync<T>(string key)
    {
        var jsonData = await _database.StringGetAsync(key);
        if (jsonData.IsNullOrEmpty)
        {
            return default;
        }
        return JsonSerializer.Deserialize<T>(jsonData.ToString());
    }
    
    public  async Task DeleteValueAsync(string key)
    {
        await _database.KeyDeleteAsync(key);
    }
}