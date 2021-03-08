namespace TriplesofLatinLetters
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintsSmallLatinLetters(n);
        }

        static void PrintsSmallLatinLetters(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int o = 0; o < n; o++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + o);
                        char thirdChar = (char)('a' + p);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
