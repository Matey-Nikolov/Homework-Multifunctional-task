using System;

namespace _08._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string a = "a" ;
            string b = "a";
            

            if (Budget <= 100 && season == "summer")
            {
                Budget = Budget * 0.3;
                a =  "Bulgaria";
                b = "Camp";
            }
            else if (Budget <= 100 && season == "winter")
            {
                Budget = Budget * 0.7;
                a = "Bulgaria";
                b = "Hotel";
            }
            else if (Budget <= 1000 && season == "summer")
            {
                Budget = Budget * 0.4;
                a = "Balkans";
                b = "Camp";
            }
            else if (Budget <= 1000 && season == "winter")
            {
                Budget = Budget * 0.8;
                a = "Balkans";
                b = "Hotel";
            }

            if (Budget > 1000 && (season == "summer" || season == "winter")) 
            {
                Budget = Budget * 0.9;
                a = "Europe";
                b = "Hotel";
            }

            Console.WriteLine($"Somewhere in {a}");
            Console.WriteLine($"{b} - {Budget:f2}");
        }
    }
}
