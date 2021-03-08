
namespace NxNMatrix
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintNn(n);
        }

        static void PrintNn(int n)
        {
            int count = 0;
            int sum = 0;
            sum = n * n;
            for (int i = 0; i < n; i++)
            {
                for (int a = 0; a < n; a++)
                {
                    Console.Write($"{n} ");
                    count++;
                }
                if (count != sum)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
