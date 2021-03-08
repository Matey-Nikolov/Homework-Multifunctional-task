using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");

                for (int y = 0; y < i; y++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
