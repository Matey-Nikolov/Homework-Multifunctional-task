namespace _16EMiner
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> resurces = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (resurces.ContainsKey(input) == false)
                {
                    resurces.Add(input, 0);
                }

                int quantity = int.Parse(Console.ReadLine());

                resurces[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var resurce in resurces)
            {
                Console.WriteLine($"{resurce.Key} -> {resurce.Value}");
            }
        }
    }
}
