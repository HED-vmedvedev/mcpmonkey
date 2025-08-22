using MyMonkeyApp;
using System;
using System.Collections.Generic;

namespace MyMonkeyApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("   🐒 Monkey Console App Menu   ");
            Console.WriteLine("==============================");
            Console.WriteLine("1) List all monkeys");
            Console.WriteLine("2) Get details for a specific monkey by name");
            Console.WriteLine("3) Get a random monkey");
            Console.WriteLine("4) Exit");
            Console.Write("Select an option (1-4): ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyDetailsByName();
                    break;
                case "3":
                    GetRandomMonkeyDetails();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void ListAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetMonkeys();
        if (monkeys.Count == 0)
        {
            Console.WriteLine("No monkeys available.");
            Console.ReadLine();
            return;
        }
        Console.WriteLine("\nAvailable Monkeys:");
        foreach (var monkey in monkeys)
        {
            Console.WriteLine($"- {monkey.Name} (Accessed {MonkeyHelper.GetAccessCount(monkey.Name)} times)");
        }
        Console.WriteLine("\nPress Enter to return to menu.");
        Console.ReadLine();
    }

    static void GetMonkeyDetailsByName()
    {
        Console.Write("Enter monkey name: ");
        string? name = Console.ReadLine();
        var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
        if (monkey == null)
        {
            Console.WriteLine("Monkey not found.");
            Console.ReadLine();
            return;
        }
        DisplayMonkeyDetails(monkey);
    }

    static void GetRandomMonkeyDetails()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        if (monkey == null)
        {
            Console.WriteLine("No monkeys available.");
            Console.ReadLine();
            return;
        }
        DisplayMonkeyDetails(monkey);
    }

    static void DisplayMonkeyDetails(Monkey monkey)
    {
        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("      Monkey Details      ");
        Console.WriteLine("==============================");
        Console.WriteLine($"Name: {monkey.Name}");
        Console.WriteLine($"Location: {monkey.Location}");
        Console.WriteLine($"Population: {monkey.Population}");
        Console.WriteLine($"Latitude: {monkey.Latitude}");
        Console.WriteLine($"Longitude: {monkey.Longitude}");
        Console.WriteLine($"Accessed: {MonkeyHelper.GetAccessCount(monkey.Name)} times");
        Console.WriteLine("------------------------------");
        Console.WriteLine("ASCII Art: \n  (\"`-\"/)\n   `=^.^=`\n   (\"`-\"/)");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }
}
