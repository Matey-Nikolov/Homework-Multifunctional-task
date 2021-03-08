using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            double lvek = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int talkingdoll = int.Parse(Console.ReadLine());
            int teddybear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            double sum = (puzzle * 2.6) + (talkingdoll * 3.0) + (teddybear * 4.10) + (minion * 8.20) + (truck * 2.0);
            double numtoys = puzzle + talkingdoll + teddybear + minion + truck;

            double Rent;
            double Profit;

            if (numtoys >= 50)
            {
               sum = sum * 0.75;
            }
           
            Rent = 0.1 * sum;
            Profit = sum - Rent;

            if (Profit >= lvek)
            {
                Profit = Profit - lvek;
                Console.WriteLine($"Yes! {Profit:f2} lv left.");
            }
            else
            {
                Profit = lvek - Profit;
                Console.WriteLine($"Not enough money! {Profit:f2} lv needed.");
            }
        }
    }
}