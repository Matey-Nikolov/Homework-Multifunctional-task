using System;

namespace Баща_ми_бояджията
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wallkv = (a * a) * 2 - (1.2 * 2);
            double wall1 = (a * b) * 2 - (2 * (1.5 * 1.5));

            double theroof = 2 * (a * b) + 2 * (a * h / 2);

            double wallw = (wallkv + wall1) / 3.4;
            double theroofR = theroof / 4.3;

            Console.WriteLine($"{wallw:f2}");
            Console.WriteLine($"{theroofR:f2}");
        }
    }
}