// MonkeyHelper.cs
// Static helper class for managing monkey data

namespace MyMonkeyApp;

using System.Collections.Generic;
using System;

/// <summary>
/// Provides helper methods for managing monkey data.
/// </summary>
public static class MonkeyHelper
{
    /// <summary>
    /// Gets a list of sample monkey species.
    /// </summary>
    /// <returns>A list of Monkey objects.</returns>
    public static List<Monkey> GetMonkeys()
    {
        return new List<Monkey>
        {
            new Monkey { Name = "Capuchin", Location = "Central & South America", Population = 100000, Latitude = -15.0, Longitude = -60.0 },
            new Monkey { Name = "Macaque", Location = "Asia, North Africa, Gibraltar", Population = 200000, Latitude = 35.0, Longitude = 105.0 },
            new Monkey { Name = "Howler", Location = "Central & South America", Population = 50000, Latitude = -10.0, Longitude = -75.0 },
            new Monkey { Name = "Spider", Location = "Central & South America", Population = 30000, Latitude = -5.0, Longitude = -70.0 },
            new Monkey { Name = "Squirrel", Location = "Central & South America", Population = 120000, Latitude = -8.0, Longitude = -65.0 }
        };
    }

    /// <summary>
    /// Gets a random monkey from the provided collection.
    /// </summary>
    /// <param name="monkeys">The collection of monkeys.</param>
    /// <returns>A random Monkey object, or null if the collection is empty.</returns>
    public static Monkey? GetRandomMonkey(List<Monkey> monkeys)
    {
        if (monkeys == null || monkeys.Count == 0)
            return null;
        var random = new Random();
        int index = random.Next(monkeys.Count);
        return monkeys[index];
    }
}
