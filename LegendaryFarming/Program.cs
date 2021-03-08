namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            Dictionary<string, int> legendaryItem = new Dictionary<string, int>();
            Dictionary<string, int> junkItem = new Dictionary<string, int>();

            legendaryItem["shards"] = 0;
            legendaryItem["fragments"] = 0;
            legendaryItem["motes"] = 0;

            bool endInput = true;

            while (endInput)
            {
                string[] keyMaterials = Console.ReadLine()
                    .ToLower()
                    .Split(" ");

                for (int i = 0; i < keyMaterials.Length; i += 2)
                {
                    int quantity = int.Parse(keyMaterials[i]);
                    string materials = keyMaterials[i + 1];

                    if (legendaryItem.ContainsKey(materials))    // Key materials
                    {
                        legendaryItem[materials] = legendaryItem[materials] + quantity;

                        if (legendaryItem[materials] >= 250)
                        {
                            switch (materials)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            legendaryItem[materials] = legendaryItem[materials] - 250;
                            endInput = false;
                            break;      //stop processing input - have legendaryItem 

                        }
                    }
                    else                // Junk material
                    {
                        if (!junkItem.ContainsKey(materials))
                            junkItem.Add(materials, 0);

                        junkItem[materials] = junkItem[materials] + quantity;
                    }
                }
            }

            legendaryItem = legendaryItem
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in legendaryItem)
                Console.WriteLine($"{item.Key}: {item.Value}");

            junkItem = junkItem
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in junkItem)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}