namespace _7.ListManipulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = "";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                    break;

                string[] commands = input.Split(' ');
                command = commands[0];

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

                    ////////////////////////////////////////////////////////////////////

                    case "Contains":
                        bool contains = numbers.Contains(int.Parse(commands[1]));

                        if (contains)
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No such number");
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                        break;

                    case "GetSum":
                        int sum = 0;

                        for (int i = 0; i < numbers.Count; i++)
                            sum += numbers[i];

                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        switch (commands[1])
                        {
                            case "<":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(commands[2]))));
                                break;

                            case ">=":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(commands[2]))));
                                break;

                            case ">":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(commands[2]))));
                                break;

                            case "<=":
                                Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(commands[2]))));
                                break;

                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
            }

            if (command == "Add" || command == "Remove" || command == "RemoveAt" || command == "Insert")
            {
                Console.WriteLine(string.Join(' ', numbers));
            }

        }
    }
}
