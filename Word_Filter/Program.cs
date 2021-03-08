namespace Word_Filter
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 == 0)
                .ToArray();

            foreach (string word in words)
                Console.WriteLine(word);

           // for (int i = 0; i < words.Length; i++)
             //   Console.WriteLine(words[i]));s
        }
    }
}
