namespace _6.ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)// премахни празните елементи.
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] commands = input.Split(' ');

                string command = commands[0];

                switch (command)
                {
                    case "Add":
                        numbers.Add(int.Parse(commands[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commands[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commands[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
