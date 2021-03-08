namespace ListofProducts
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // Count = 4
            List<string> products = new List<string>();// (add n)

            // add 5 element

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                //products[i] = Console.ReadLine();
                products.Add(currentProduct);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

        }
    }
}
