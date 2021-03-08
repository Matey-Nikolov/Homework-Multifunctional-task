namespace ex1._4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int max = int.MinValue;
            int min = int.MaxValue;

            int maxAfterMin = 0;
            int minAfterMax = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    maxAfterMin = min;
                }
                else if (numbers[i] > max)
                {
                    minAfterMax = max;
                    max = numbers[i];
                }
            }

            Console.WriteLine(maxAfterMin);
            Console.WriteLine(minAfterMax);
        }
    }
}
