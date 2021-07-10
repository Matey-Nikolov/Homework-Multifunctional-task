namespace Wardrobe
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colorClothesCount = new Dictionary<string, Dictionary<string, int>>();

            string[] stringSeparators = new string[] { " -> "};
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!colorClothesCount.ContainsKey(color))
                    colorClothesCount.Add(color, new Dictionary<string, int>());

                foreach (string countClother in clothes)
                {
                    if (!colorClothesCount[color].ContainsKey(countClother))
                        colorClothesCount[color].Add(countClother, 0);

                    colorClothesCount[color][countClother]++;
                }
            }

            string[] input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string findColor = input2[0];
            string findClother = input2[1];

            foreach (var colorClothing in colorClothesCount)
            {
                Console.WriteLine($"{colorClothing.Key} clothes:");

                foreach (var clotherCount in colorClothing.Value)
                {
                    if (colorClothing.Key.Contains(findColor) && clotherCount.Key.Contains(findClother))
                        Console.WriteLine($"* {findClother} - {clotherCount.Value} (found!)");
                    else
                        Console.WriteLine($"* {clotherCount.Key} - {clotherCount.Value}");
                }
            }
        }
    }
}