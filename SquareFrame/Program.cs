using System;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string("+"));
            Console.Write(new string('-', n - 2));
            Console.WriteLine(new string("+"));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string("|"));
                Console.Write(new string('-', n - 2));
                Console.WriteLine(new string("|"));
            }

            Console.Write(new string("+"));
            Console.Write(new string('-', n - 2));
            Console.WriteLine(new string("+"));
        }
    }
}
