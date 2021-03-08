namespace TEST2021_8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            Dictionary<char, int> charOne = new Dictionary<char, int>();

            string words = Console.ReadLine()
                .ToLower()
                .ToString();

            for (int i = 0; i < words.Length; i++)
            {

                if (!charOne.ContainsKey(words[i]))
                {
                    charOne.Add(words[i], 1);
                }
                else
                {
                    charOne[words[i]] +=  1;
                }
            }

            charOne = charOne.Where(w => w.Value == 1).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in charOne)
                Console.WriteLine($"{item.Key} - {item.Value}");

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
