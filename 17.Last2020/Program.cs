namespace _17.Last2020
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] bombData = Console.ReadLine().Split();

            int bomb = int.Parse(bombData[0]);
            int power = int.Parse(bombData[1]);

            while (true)
            {
                int indexOfBomb = input.IndexOf(bomb);

                int start = indexOfBomb - power;
                int count = 2 * power + 1;

                if (indexOfBomb == -1)
                    break;
                
                if (start < 0)
                {
                    start = 0;
                    count = power * 2 + 1 + (indexOfBomb - power);
                }

                if (start + count > input.Count() - 1)
                {
                    count = input.Count - start;
                }

                input.RemoveRange(start, count);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
