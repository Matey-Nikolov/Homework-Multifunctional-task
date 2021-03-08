namespace AMinerTask
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, long> miner = new Dictionary<string, long>();

            string resource = Console.ReadLine();

            long quantity = 0;

            while (resource != "stop")
            {
                quantity = long.Parse(Console.ReadLine());


                if (miner.ContainsKey(resource) == false)
                    miner.Add(resource, 0);

                miner[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var mine in miner)
                Console.WriteLine($"{mine.Key} -> {mine.Value}");
        }
    }
}
