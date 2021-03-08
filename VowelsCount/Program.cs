using System;

namespace VowelsCount
{
    class Program
    {
        static void Main()
        {
            string abc = Console.ReadLine().ToLower();
            CalculateVowels(abc);
        }

        static void CalculateVowels(string abc)
        {
            int sum = 0;
            int total = 0;

            for (int i = 0; i < abc.Length; i++)
            {
                sum = abc[i];
               
                switch (sum)
                {
                    case 'a':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'e':
                        total++;
                        break;
                }
            }
            Console.WriteLine(total);
        }
    }
}
