using System;

namespace Кола
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string a = "";
            string b = "";

            if (budget <= 100)
            {
                a = "Economy class";
                switch (season)
                {
                    case "Summer":
                        budget = budget * 0.35;
                        b = "Cabrio";
                        break;
                    case "Winter":
                        budget = budget * 0.65;
                        b = "Jeep";
                        break;
                }

            }
            else if (budget >= 100 && budget <= 500)
            {
                a = "Compact class";
                switch (season)
                {
                    case "Summer":
                        budget = budget * 0.45;
                        b = "Cabrio";
                        break;
                    case "Winter":
                        budget = budget * 0.80;
                        b = "Jeep";
                        break;
                }
            }
            else if (budget > 500)
            {
                a = "Luxury class";
                switch (season)
                {
                    case "Summer":
                    case "Winter":
                        budget = budget * 0.9;
                        b = "Jeep";
                        break;
                }
            }

            Console.WriteLine($"{a}");
            Console.WriteLine($"{b} - {budget:f2}");

        }
    }
}
