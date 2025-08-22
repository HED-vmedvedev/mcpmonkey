using MyMonkeyApp;
using System;
using System.Collections.Generic;

namespace MyMonkeyApp;

class Program
{
    static void Main(string[] args)
    {
        List<Monkey> monkeys = MonkeyHelper.GetMonkeys();
        if (monkeys == null || monkeys.Count == 0)
        {
            Console.WriteLine("No monkeys available in the collection.");
            return;
        }

        bool continuePicking = true;
        while (continuePicking)
        {
            Monkey? selectedMonkey = MonkeyHelper.GetRandomMonkey(monkeys);
            if (selectedMonkey == null)
            {
                Console.WriteLine("No monkeys available in the collection.");
                break;
            }

            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("   🐒 Monkey Selector Console   ");
            Console.WriteLine("==============================");
            Console.WriteLine($"Name: {selectedMonkey.Name}");
            Console.WriteLine($"Location: {selectedMonkey.Location}");
            Console.WriteLine($"Population: {selectedMonkey.Population}");
            Console.WriteLine($"Latitude: {selectedMonkey.Latitude}");
            Console.WriteLine($"Longitude: {selectedMonkey.Longitude}");
            Console.WriteLine("------------------------------");
            Console.WriteLine("ASCII Art: \n  (\"`-\"/)");
            Console.WriteLine("   `=^.^=`");
            Console.WriteLine("   (\"`-\"/)");
            Console.WriteLine("    `=^.^=`");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Pick another monkey? (y/n): ");
            string? userInput = Console.ReadLine();
            continuePicking = userInput?.Trim().ToLower() == "y";
        }
        Console.WriteLine("Thank you for using Monkey Selector!");
    }
}
