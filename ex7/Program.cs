namespace ex7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(ReturnSum(num));
        }

         static int ReturnSum(List<int> num)
         {
            int sum = 0;
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum += num[i];
                }
            }
            return sum;
         }
    }
}
