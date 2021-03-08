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
            wine = wine * 2.5;

            if (wine < z)
            {
                z = wine - z;
                Console.WriteLine($"It will be a tough winter! More {z} liters wine needed.");
            }

        }
    }
}
