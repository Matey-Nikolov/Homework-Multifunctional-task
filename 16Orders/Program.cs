namespace _16Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            string[] input = Console.ReadLine()
                .Split();

            while (input[0] != "buy")
            {
                string productName = input[0];
                double price = double.Parse( input[1]);
                int cap = int.Parse(input[2]);

                if (products.ContainsKey(productName))
                {
                    if (!products[productName].ContainsKey(price))
                    {
                        products[productName].Add(price, 0);
                    }
                    products[productName][price] += cap;
                }
                else
                {
                    products.Add(productName, new Dictionary<double, int>());
                    products[productName].Add(price, cap);
                }

                input = Console.ReadLine()
                .Split();
            }

            foreach (var product in products)
            {


                Console.WriteLine($"{product.Key} -> {product.Value.Last().Key * product.Value.Values.Sum():f2}");
            }
        }
    }
}
