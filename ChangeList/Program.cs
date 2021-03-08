namespace ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
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
                    case "Delete":
                        numbers.RemoveAll(n => n == int.Parse(commands[1]));
                        break;

                    case "Insert":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
