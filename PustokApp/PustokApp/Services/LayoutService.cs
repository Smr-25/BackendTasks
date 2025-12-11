using Pustok.Data;

namespace Pustok.Services;

public class LayoutService(AppDbContext context)
{
    public Dictionary<string, string> GetSettings()
    {
        return context.Settings.ToDictionary(x => x.Key, x => x.Value);
    }
}