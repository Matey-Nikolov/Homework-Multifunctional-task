using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            double total = 0;

            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia": total = price * 0.50; break;
                        case "Plovdiv": total = price * 0.40; break;
                        case "Varna": total = price * 0.45; break;
                    }
                    break;
                case "water":
                    switch (city)
                    {
                        case "Sofia": total = price * 0.80; break;
                        case "Plovdiv": total = price * 0.70; break;
                        case "Varna": total = price * 0.70; break;
                    }
                    break;
                case "beer":
                    switch (city)
                    {
                        case "Sofia": total = price * 1.20; break;
                        case "Plovdiv": total = price * 1.15; break;
                        case "Varna": total = price * 1.10; break;
                    }
                    break;
                case "sweets":
                    switch (city)
                    {
                        case "Sofia": total = price * 1.45; break;
                        case "Plovdiv": total = price * 1.30; break;
                        case "Varna": total = price * 1.35; break;
                    }
                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "Sofia": total = price * 1.60; break;
                        case "Plovdiv": total = price * 1.50; break;
                        case "Varna": total = price * 1.50; break;
                    }
                    break;
            }
            Console.WriteLine($"{total}");
        }
    }
}
