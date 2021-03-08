using System;

namespace dvor
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double price = area * 7.61;
            double price2 = price * 0.18;
            double finalPrice = price - price2;

            Console.WriteLine($"The final price is: {price:f2} lv.");

            Console.WriteLine($"the discount is: {price2:f2} lv.");
            
        }
    }
}
