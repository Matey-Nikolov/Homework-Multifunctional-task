namespace _16FarmingV2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"Shards", 0},
                { "Motes", 0},
                { "Fragments", 0},
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, string> specialItems = new Dictionary<string, string>
            {
                { "shards", "Shadowmourne"},
                { "fragments", "Valanyr"},
                { "motes", "Dragonwrat"},
            };

            string type = "";
            bool isColleced = false;

            while (true)
            {


                string[] inputData = Console.ReadLine()
                    .Split();

                for (int i = 0; i < inputData.Length - 1; i+= 2)
                {
                    int quantity = int.Parse(inputData[i]);
                    string material = inputData[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            type = material;
                            isColleced = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }

                    if (isColleced)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"{specialItems[type]} obtained!");

            foreach (var item in materials
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string materialName = item.Key;
                int quantity = item.Value;
                Console.WriteLine($"{materialName}: {quantity}");
            }

            foreach (var item in junk
                .OrderBy(x => x.Key))
            {
                string materialName = item.Key;
                int quantity = item.Value;
                Console.WriteLine($"{materialName}: {quantity}");
            }
        }
    }
}
