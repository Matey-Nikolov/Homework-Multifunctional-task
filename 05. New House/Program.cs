using System;

namespace _05._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            double Budget = double.Parse(Console.ReadLine());

            double price = 0;


            switch (name)
            {
                case "Roses":
                    price = flowers * 5.00;
                    if (flowers > 80)
                    {
                        price = price - 0.1 * price;
                    }
                    break;
                case "Dahlias":
                    price = flowers * 3.80;
                    if (flowers > 90)
                    {
                        price = price - 0.15 * price;
                    }
                    break;
                case "Tulips":
                    price = flowers * 2.80;
                    if (flowers > 80)
                    {
                        price = price - 0.15 * price;
                    }
                    break;
                case "Narcissus":
                    price = flowers * 3.00;
                    if (flowers < 120)
                    {
                        price = price + 0.15 * price;
                    }
                    break;
                case "Gladiolus":
                    price = flowers * 2.50;
                    if (flowers < 80)
                    {
                        price = price + 0.2 * price;
                    }
                    break;
            }
            
            if (Budget >= price)
            {
                Budget = Budget - price;
                Console.WriteLine($"Hey, you have a great garden with {flowers} {name} and {Budget:f2} leva left.");
            }
            else
            {
                Budget = price - Budget;
                Console.WriteLine($"Not enough money, you need {Budget:f2} leva more.");
            }

        }
    }
}