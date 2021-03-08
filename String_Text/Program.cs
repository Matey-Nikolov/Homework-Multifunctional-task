using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Text
{
    class Program
    {
        static void Main()
        {
            List<string> validUsernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string valid = "";

            foreach (string item in validUsernames)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    foreach (char item2 in item)
                    {
                        if (char.IsLetterOrDigit(item2))
                        {
                            if (item2 != '_' && item2 != '-')
                            {
                                valid = item;
                            }
                        }
                    }

                }
            }
            Console.WriteLine(valid);
        }
    }
}