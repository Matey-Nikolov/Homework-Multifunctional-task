namespace _16Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> resources = new Dictionary<string, int>
            {
                {"Shards", 0},
                { "Fragments", 0},
                { "Motes", 0},
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            Dictionary<string, string> LegendaryItems = new Dictionary<string, string>
            {
                { "shards", "Shadowmourne"},
                { "fragments", "Valanyr"},
                { "motes", "Dragonwrat"},
            };

            bool hasLegendItem = false;
            string type = "";

            while (true)
            {
                if (type.Length != 0) break;

                string[] data = Console.ReadLine()
                    .Split();

                for (int i = 0; i < data.Length - 1; i+= 2)
                {
                    int quantity = int.Parse(data[i]);
                    string resource = data[i + 1].ToLower();

                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;

                        if (resources[resource] >= 250)
                        {
                            type = resource;
                            resources[resource] -= 250;

                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(resource))
                            junk[resource] = 0; 

                        junk[resource] += quantity;
                        
                    }
                }
            }

            Console.WriteLine($"{LegendaryItems[type]} obtained!");


            foreach (var item in resources.OrderByDescending(x => x.Value)
                                           .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
