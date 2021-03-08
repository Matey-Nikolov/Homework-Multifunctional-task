using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            String productName = Console.ReadLine();
            String city = Console.ReadLine();

            double quantity = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (city == "Sofia")
            {
                if (productName == "coffee")
                {
                    price = 0.50;
                }
                else if (productName == "water")
                {
                    price = 0.80;
                }
                else if (productName == "beer")
                {
                    price = 1.20;
                }
                else if (productName == "sweets")
                {
                    price = 1.45;
                }
                else if (productName == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (city == "Plovdiv")
            {
                if (productName == "coffee")
                {
                    price = 0.40;
                }
                else if (productName == "water")
                {
                    price = 0.70;
                }
                else if (productName == "beer")
                {
                    price = 1.15;
                }
                else if (productName == "sweets")
                {
                    price = 1.30;
                }
                else if (productName == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (city == "Varna")
            {
                if (productName == "coffee")
                {
                    price = 0.45;
                }
                else if (productName == "water")
                {
                    price = 0.70;
                }
                else if (productName == "beer")
                {
                    price = 1.10;
                }
                else if (productName == "sweets")
                {
                    price = 1.35;
                }
                else if (productName == "peanuts")
                {
                    price = 1.55;
                }
            }

            price = price * quantity;
            Console.WriteLine($"{price:f2}");

        }
    }
}
