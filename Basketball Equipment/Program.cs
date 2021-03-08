using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int theannualfeeforbasketballtraining = int.Parse(Console.ReadLine());

            double priceofbasketballsneakers = theannualfeeforbasketballtraining - (0.4 * theannualfeeforbasketballtraining);
            double priceofabasketballteam = priceofbasketballsneakers - (0.2 * priceofbasketballsneakers);
            double priceofabasketball = priceofabasketballteam / 4.0;
            double priceofbasketballaccessories = priceofabasketball / 5.0;

            double total = theannualfeeforbasketballtraining + priceofbasketballsneakers + priceofabasketballteam + priceofabasketball + priceofbasketballaccessories;

            Console.WriteLine($"{total:f2}");
        }
    }
}
