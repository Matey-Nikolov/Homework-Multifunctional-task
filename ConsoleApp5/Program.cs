using System;

namespace _25._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int br = int.Parse(Console.ReadLine());

            double wine = 0;

            wine = x * 0.4;
            wine = wine * y;
            wine = wine / 2.5;
           // Console.WriteLine(wine);

            if (wine >=  z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                wine = wine - z;
                double a = 0;
                a = wine / br;
                Console.WriteLine($"{Math.Ceiling(wine)} liters left -> {Math.Ceiling(a)} liters per person.");
            }
            else 
            {
                double a = 0;
                a = z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(a)} liters wine needed.");
            }

        }
    }
}
