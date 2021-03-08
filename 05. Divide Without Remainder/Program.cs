using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0.00;
            double p2 = 0.00;
            double p3 = 0.00;


            double total = 0.0;
            double total1 = 0.0;
            double total2 = 0.0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    total++;
                }
                if (num % 3 == 0)
                {
                    total1++;
                }
                if (num % 4 == 0)
                {
                    total2++;
                }
            }

            p1 = total / n * 100;
            p2 = total1 / n * 100;
            p3 = total2 / n * 100;


            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
