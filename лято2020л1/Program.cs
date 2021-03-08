using System;

namespace лято2020л1
{
    class Program
    {
        static void Main(string[] args)
        {
            int contributions = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < contributions; i++)
            {
                double money = double.Parse(Console.ReadLine());

                if (money > 0)
                {
                    Console.WriteLine($"Increase: {money:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total = total + money;
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
