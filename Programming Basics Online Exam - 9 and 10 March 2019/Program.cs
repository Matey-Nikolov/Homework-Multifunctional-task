using System;

namespace Programming_Basics_Online_Exam___9_and_10_March_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricetennisracket = double.Parse(Console.ReadLine());
            int numberoftennisrackets = int.Parse(Console.ReadLine());
            int numberofpairsofsneakers = int.Parse(Console.ReadLine());

            double price = pricetennisracket * numberoftennisrackets;
            double pairofsneakers = (pricetennisracket / 6) * numberofpairsofsneakers;
            double totalcost = price + pairofsneakers;
            totalcost = totalcost + totalcost * 0.2;



            double priceforDjokovic = Math.Floor(totalcost / 8);
            double priceforsponsors = Math.Ceiling(totalcost * 7 / 8);

            Console.WriteLine($"Price to be paid by Djokovic {priceforDjokovic}");
            Console.WriteLine($"Price to be paid by sponsors {priceforsponsors}");
        }
    }
}
