namespace _4ListOperations
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

                if (input == "End")
                    break;

                string[] commands = input.Split(' ');
                command = commands[0];

                switch (command)
                {
                    case "Add":
                        numbers.Add(int.Parse(commands[1]));
                        break;
                    case "Remove":
                        if (int.Parse(commands[1]) <= numbers.Count)
                            numbers.RemoveAt(int.Parse(commands[1]));
                        else
                            Console.WriteLine("Invalid index");
                        break;
                    case "Insert":
                        if (int.Parse(commands[2]) <= numbers.Count)
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        else
                            Console.WriteLine("Invalid index");
                        break;
                    case "Shift":
                        switch (commands[1])
                        {
                            case "left":
                                for (int i = 0; i < int.Parse(commands[2]); i++)
                                {
                                    numbers.Add(numbers[0]);
                                    numbers.RemoveAt(0);
                                }
                                break;

                            case "right":
                                for (int i = 0; i < int.Parse(commands[2]); i++)
                                {
                                    numbers.Insert(0, numbers[numbers.Count - 1]);
                                    numbers.RemoveAt(numbers.Count - 1);
                                }
                                break;
                        }
                        break;

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
