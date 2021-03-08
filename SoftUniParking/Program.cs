namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> commands = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                if (command[0] == "register")
                {
                    if (commands.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                    else
                    {
                        commands.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (commands.ContainsKey(command[1]))
                    {
                        commands.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }

            foreach (var user in commands)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}