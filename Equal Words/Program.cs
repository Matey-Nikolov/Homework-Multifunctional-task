using System;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();
            String word1 = Console.ReadLine();

            word = word.ToLower();
            word1 = word1.ToLower();

            if (word == word1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
