namespace PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> distancesPokemon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();



            for (int i = 0; i < distancesPokemon.Count; i++)
            {
                int index = int.Parse(Console.ReadLine());

                if (distancesPokemon[index] > distancesPokemon[i])
                {

                }
                distancesPokemon.RemoveAt(index);

                Console.WriteLine(string.Join(" ", distancesPokemon));
            }
        }
    }
}

