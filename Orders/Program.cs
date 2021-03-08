using System;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double totalprice = 0;

            PrintPrice(product, price, totalprice);

        }

        static void PrintPrice(string product, double price, double totalprice)
        {
            //   double totalprice = 0;
            switch (product)
            {
                case "coffee": totalprice = price * 1.50; break;
                case "coke": totalprice = price * 1.40; break;
                case "water": totalprice = price * 1.00; break;
                case "snacks": totalprice = price * 2.00; break;
            }
            Console.WriteLine($"{totalprice:f2}");

        }
    }
}