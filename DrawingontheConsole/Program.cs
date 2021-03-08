using System;

namespace DrawingontheConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <= n; row++)
            {

                for (int c1 = 1; c1 <= (n - row); c1++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int c2 = 1; c2 <= row - 1; c2++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= n - 1; row++)
            {

                for (int c1 = 1; c1 <= (row); c1++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                for (int c2 = 1; c2 < n - row; c2++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
