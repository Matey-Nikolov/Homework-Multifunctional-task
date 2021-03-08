using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string positiveornegative = Console.ReadLine();

            double price = 0;
            days = days - 1; // работя в нощувки

            switch (room)
            {
                case "room for one person": price = days * 18.00; break;
                case "apartment": price = days * 25.00; break;
                case "president apartment": price = days * 35.00; break;
            }

            if (days < 10)
            {
                switch (room)
                {
                    case "apartment": price = price - price * 0.3; break;
                    case "president apartment": price = price - price * 0.1; break;
                }
            }
            else if (10 <= days && days <= 15)
            {
                switch (room)
                {
                    case "apartment": price = price - price * 0.35;  break;
                    case "president apartment": price = price - price * 0.15; break;
                }
            }
            else if (days > 15)
            {
                switch (room)
                {
                    case "apartment": price = price - price * 0.5; break;
                    case "president apartment": price = price - price * 0.2; break;
                }
            }

            if (positiveornegative == "positive")
                price = price + price * 0.25;
            else
                price = price - price * 0.1;

            Console.WriteLine($"{price:f2}");
        }
    }
}
