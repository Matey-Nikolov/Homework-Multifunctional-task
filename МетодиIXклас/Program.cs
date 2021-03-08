using System;

namespace МетодиIXклас
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower(); // .ToLower

            int count = CalculateCountOfVowels(text);
            PrintResult(count);

        }

        private static void PrintResult(int count)
        {
            Console.WriteLine(count);
        }

        static int CalculateCountOfVowels(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'e':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
