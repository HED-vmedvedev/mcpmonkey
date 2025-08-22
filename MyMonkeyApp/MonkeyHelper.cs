// MonkeyHelper.cs
// Static helper class for managing monkey data

namespace MyMonkeyApp;

using System.Collections.Generic;

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
            new Monkey { Name = "Capuchin", Location = "Central & South America", Population = 100000 },
            new Monkey { Name = "Macaque", Location = "Asia, North Africa, Gibraltar", Population = 200000 },
            new Monkey { Name = "Howler", Location = "Central & South America", Population = 50000 },
            new Monkey { Name = "Spider", Location = "Central & South America", Population = 30000 },
            new Monkey { Name = "Squirrel", Location = "Central & South America", Population = 120000 }
        };
    }
}
