namespace LongestIncreasingSubsequence_LIS_
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];

            int left = 0;
            int maxLen = 1;


            for (int p = 0; p < nums.Length; p++)
            {
                len[p] = 1;
                prev[p] = -1;

                for (int k = 0; k < p; k++)
                {
                    if (nums[k] < nums[p] && len[k] + 1 > len[p])
                    {
                        len[p] = len[k] + 1;
                        prev[p] = k;
                    }
                }

                if (len[p] > maxLen)
                {
                    maxLen = len[p];
                    left = p;
                }
            }

            Console.WriteLine(string.Join(' ', nums));
            Console.WriteLine(string.Join(' ', len));
            Console.WriteLine(string.Join(' ', prev));
           
            Console.WriteLine(maxLen + " ");

            Console.WriteLine(left + " ");

            int[] newarray = new int[maxLen]; 

            while (maxLen > 0)
            {
                maxLen--;
                newarray[maxLen] = nums[left];
                left = prev[left];
            }
            Console.Write(string.Join(' ', newarray));
        }
    }
}
