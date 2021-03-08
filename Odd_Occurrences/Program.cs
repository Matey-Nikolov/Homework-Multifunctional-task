namespace Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(" ")
                .ToArray();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (counts.ContainsKey(words[i]))
                {
                    counts[words[i]]++;
                }
                else
                {
                    counts.Add(words[i], 0);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 == 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
    }
}
