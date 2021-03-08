using System;

namespace _09._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double pricewashingmachine = double.Parse(Console.ReadLine());
            int gmaeprice = int.Parse(Console.ReadLine());

            int sum = 0;
            int game = 0;
            double total = 0;

            int br = 0;

            for (int i = 1; i <= age; i ++)
            {
                if (i % 2 == 0)
                {
                  sum = sum + 10;
                  br++;
                  total = total + sum;
                }
                else 
                {
                    game ++;
                }

            }

            game = game * gmaeprice;
            total = (total + game) - br;

            if (total >= pricewashingmachine)
            {
                total = total - pricewashingmachine;

                Console.WriteLine($"Yes! {total:f2}");
            }
            else
            {
                total = pricewashingmachine - total;
                Console.WriteLine($"No! {total:f2}");
            }
        }
    }
}
