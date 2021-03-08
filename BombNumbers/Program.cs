namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> bomb = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int numBomb = bomb[0];
            int power = bomb[1];

            while (numbers.Contains(numBomb))
            {
                int indexBomb = numbers.IndexOf(numBomb);

                int startBlast = indexBomb - power >= 0 ? indexBomb - power : 0;

                int blast = power * 2 + 1;

                if (indexBomb + blast > numbers.Count)
                    blast = numbers.Count - (indexBomb - power);

                if (indexBomb - power < 0)
                    blast = blast - Math.Abs(indexBomb - power);

                numbers.RemoveRange(startBlast, blast);
            }
            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}