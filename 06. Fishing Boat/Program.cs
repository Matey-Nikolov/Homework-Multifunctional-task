using System;

namespace _06._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int Budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int broiR = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                    price = 4200;
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (broiR <= 6)
            {
                price = price - 0.1 * price;
            }
            else if (broiR >= 7 && broiR <= 11)
            {
                price = price - 0.15 * price;
            }
            else if (broiR > 12)
            {
                price = price - 0.25 * price;
            }

           // Console.WriteLine(price);

            if (broiR%2 == 0 && !(season=="Autumn"))
            {
                price = price - 0.05 * price;
            }
           
          //  Console.WriteLine(price);

            if (Budget >= price)
            {
                price = Budget - price;
                Console.WriteLine($"Yes! You have {price:f2} leva left.");
            }
            else if (Budget <= price)
            {
                price = price - Budget;
                Console.WriteLine($"Not enough money! You need {price:f2} leva.");
            }


        }
    }
}