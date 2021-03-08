
namespace Problem2
{
    using System;

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
            for (int i = 0; i < n; i++)
            {
                PrintTop(n);
               // PrintFoot(n);
            }
        }

        static void PrintFoot(int n)
        {
            int stars = 0;
            int lines = 0;

            if (n % 2 == 0)
            { stars = 2; lines = (n / 2 - 1); }
            else
            { stars = 1; lines = (n / 2); }

            Console.Write(new string('*', lines));
            Console.Write(new string('*', stars - 1));
            Console.WriteLine(new string('*', lines - 2 ));

        }

        static void PrintTop(int n)
        {
            int h = 2 * n;
            
            if (n % 2 == 0)
            {
                Console.WriteLine(" ** ");
                for (int i = 1; i < n; i++)
                {
                    Console.Write("*", n);
                }
                Console.Write("*", n + 3);
            }


        }
    }
}
