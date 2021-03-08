namespace ex6
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            double[] num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Console.WriteLine(ReturnSum(num));
        }

        static double ReturnSum(double[] num)
        {
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            return sum;
        }
    }
}
