namespace LongestLncreasingSubsequence_LIS_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] result = new int[input.Length];
            int[] length = new int[input.Length];
            int[] prevIndex = new int[input.Length];

            int count = 0;
            length[0] = 1;
            prevIndex[0] = - 1;

            for (int i = 1; i <= input.Length; i++)
            {
                // 3 14 5 12
                // 14 < 5 || 3 < 14
                // 5 < 12 || 14 < 5

                if (input[i] < input[i + 1] && input[i - 1] < input[i])
                {
                    count++;
                    length[i] = count;
                    prevIndex[i] = i - 1;
                }


            }
        }
    }
}
