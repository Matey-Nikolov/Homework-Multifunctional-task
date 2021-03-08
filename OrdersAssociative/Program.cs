namespace OrdersAssociative
{

    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>> ();

            string[] input = Console.ReadLine()
                .Split(" ");

            while (input[0] != "buy")
            {
                double price = double.Parse(input[1]);
                double count = double.Parse(input[2]);

                if (orders.ContainsKey(input[0]))
                {

                }
                else
                {
                    orders.Add(input[0], new List<double>());
                }

                orders[input[0]].Add(price * count);

                input = Console.ReadLine()
                    .Split(" ");
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value):f2}");
            }
        }
    }
}