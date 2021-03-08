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
            double p4 = 0.00;
            double p5 = 0.00;

            double total = 0;
            double total1 = 0;
            double total2 = 0;
            double total3 = 0;
            double total4 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    total ++;
                  //    p1 = total / n * 100;
                }
                else if (num >= 200 && num <= 399)
                {
                    total1 ++;
                  //  p2 = total1 / n * 100;
                }
                else if (num >= 400 && num <= 599)
                {
                    total2 ++;
                 //   p3 = total2 / n * 100;
                }
                else if (num >= 600 && num <= 799)
                {
                    total3 ++;
                 //    p4 = total3 / n * 100;
                }
                else if (num >= 800)
                {
                    total4 ++;
                 //   p5 = total4 / n * 100;
                }
            }

            p1 = total / n * 100;
            p2 = total1 / n * 100;
            p3 = total2 / n * 100;
            p4 = total3 / n * 100;
            p5 = total4 / n * 100;


            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
