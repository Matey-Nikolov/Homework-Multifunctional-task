namespace _2GaussTrick
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

            int first = numbers.Count;

            for (int i = 0; i < first / 2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
