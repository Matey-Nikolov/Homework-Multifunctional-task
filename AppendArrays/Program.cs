namespace AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> array = Console.ReadLine()
                .Split('|')
                .ToList();

            array.Reverse();

            for (int i = 0; i < array.Count; i++)
            {
                List<string> newarrays = new List<string>();
                newarrays = array[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Console.Write(string.Join(" ", newarrays));

                if (i < array.Count - 1)
                    Console.Write(" ");

            }
        }
    }
}
