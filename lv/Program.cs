using System;

namespace lv
{
    class Program
    {
        static void Main(string[] args)
        {
           int  dog = int.Parse(Console.ReadLine());

            int ost = int.Parse(Console.ReadLine());

            double sum = dog * 2.5 + ost * 4;

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
