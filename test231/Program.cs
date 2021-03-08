using System;

namespace test231
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricevegetables = double.Parse(Console.ReadLine());
            double pricefruit = double.Parse(Console.ReadLine());
            int totalvegetables = int.Parse(Console.ReadLine());
            int totalfruit = int.Parse(Console.ReadLine());

            double total = (pricevegetables * totalvegetables);
            double total1 = (pricefruit * totalfruit);
            double total2 = (total + total1) / 1.94;

            Console.WriteLine($"{total2:f2}");

        }
    }
}