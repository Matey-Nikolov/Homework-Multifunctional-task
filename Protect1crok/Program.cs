namespace Protect1crok
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                numbers.Add(num);
            }

            Console.WriteLine(ReturnSumDigits(numbers));
        }



        static int ReturnSumDigits(List<int> num)
        {
            int sum = 0;

            for (int i = 0; i < num.Count; i++)
            {
                int nums = num[i];

                while (nums != 0)
                {
                    int gigit = nums % 10;
                    sum += gigit;
                    nums /= 10;
                }
            }

            return sum;
        }
    }
}
