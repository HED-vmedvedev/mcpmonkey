// MonkeyHelper.cs
// Static helper class for managing monkey data

namespace MyMonkeyApp;

using System.Collections.Generic;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

/// <summary>
/// Provides helper methods for managing monkey data.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys;
    private static readonly Dictionary<string, int> accessCounts = new();

    static MonkeyHelper()
    {
        // Initialize with local data; replace with MCP server integration as needed
        monkeys = new List<Monkey>
        {
            new Monkey { Name = "Capuchin", Location = "Central & South America", Population = 100000, Latitude = -15.0, Longitude = -60.0 },
            new Monkey { Name = "Macaque", Location = "Asia, North Africa, Gibraltar", Population = 200000, Latitude = 35.0, Longitude = 105.0 },
            new Monkey { Name = "Howler", Location = "Central & South America", Population = 50000, Latitude = -10.0, Longitude = -75.0 },
            new Monkey { Name = "Spider", Location = "Central & South America", Population = 30000, Latitude = -5.0, Longitude = -70.0 },
            new Monkey { Name = "Squirrel", Location = "Central & South America", Population = 120000, Latitude = -8.0, Longitude = -65.0 }
        };
    }

    /// <summary>
    /// Gets all monkeys in the collection.
    /// </summary>
    public static List<Monkey> GetMonkeys() => monkeys;

    /// <summary>
    /// Gets a random monkey from the collection and tracks access count.
    /// </summary>
    public static Monkey? GetRandomMonkey()
    {
        if (monkeys.Count == 0) return null;
        var random = new Random();
        int index = random.Next(monkeys.Count);
        var monkey = monkeys[index];
        TrackAccess(monkey.Name);
        return monkey;
    }

    /// <summary>
    /// Finds a monkey by name and tracks access count.
    /// </summary>
    public static Monkey? GetMonkeyByName(string name)
    {
        var monkey = monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (monkey != null) TrackAccess(monkey.Name);
        return monkey;
    }

    /// <summary>
    /// Gets the access count for a monkey by name.
    /// </summary>
    public static int GetAccessCount(string name)
    {
        return accessCounts.TryGetValue(name, out int count) ? count : 0;
    }

    private static void TrackAccess(string name)
    {
        if (accessCounts.ContainsKey(name))
            accessCounts[name]++;
        else
            accessCounts[name] = 1;
    }

    /// <summary>
    /// Placeholder for MCP server integration to fetch monkeys asynchronously.
    /// </summary>
    public static async Task<List<Monkey>> FetchMonkeysFromMcpServerAsync(string apiUrl)
    {
        // TODO: Implement actual MCP server API call
        using var httpClient = new HttpClient();
        // Example: var response = await httpClient.GetAsync(apiUrl);
        // Parse response and return monkey list
        return new List<Monkey>();
    }
}
