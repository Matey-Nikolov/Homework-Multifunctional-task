using System;

namespace _07._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (i % 2 == 0) 
                    evenSum += element;
                else 
                    oddSum += element;
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                total = oddSum - evenSum;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(total)}");
            }
        }
    }
}
