namespace CardsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> deckCards1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> deckCards2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();



            while (true)
            {

                if (deckCards1[0] > deckCards2[0])
                {
                    deckCards1.Add(deckCards1[0]);
                    deckCards1.Add(deckCards2[0]);

                    deckCards1.Remove(deckCards1[0]);
                    deckCards2.Remove(deckCards2[0]);
                }
                else if (deckCards1[0] < deckCards2[0])
                {
                    deckCards2.Add(deckCards2[0]);
                    deckCards2.Add(deckCards1[0]);

                    deckCards2.Remove(deckCards2[0]);
                    deckCards1.Remove(deckCards1[0]);
                }
                else if (deckCards1[0] == deckCards2[0])
                {
                    deckCards1.Remove(deckCards1[0]);
                    deckCards2.Remove(deckCards2[0]);
                }

                if (deckCards1.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {deckCards2.Sum()}");
                    break;
                }
                else if (deckCards2.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {deckCards1.Sum()}");
                    break;
                }
            }
        }
    }
}