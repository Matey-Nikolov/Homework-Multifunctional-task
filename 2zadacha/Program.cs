using System;

namespace _2zadacha
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine($"{n} is invalid number");
                return;
            }

            if (n % 2 == 0)
            {
                int starscount = 0;
                PrintTop(n, starscount);
                PrintFoot(n, starscount);

            }
            else
            {

            }
        }

        static void PrintTop(int n, int starscount)
        {
            for (int row = 0; row < n * 2 - 1; row++)
            {
                Console.WriteLine(new string(' ', n - 1 - row) + new string('*', starscount));
                starscount += 2;
            }

        }

        static void PrintFoot(int n, int starscount)
        {
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine();
            }


        }
    }
}
