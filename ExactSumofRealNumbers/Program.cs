
namespace ExactSumofRealNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal num = ReturnExactSum(n);
            Console.WriteLine(num);
        }

        static decimal ReturnExactSum(decimal n)
        {
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            return sum;
        }
    }
}
