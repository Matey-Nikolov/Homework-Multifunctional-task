using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxCombination = int.MinValue;
            string winner = string.Empty;
            while (input != "STOP")
            {
                int currentSum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    currentSum += input[i];
                }

                if (currentSum > maxCombination)
                {
                    maxCombination = currentSum;
                    winner = $"Winner is {input} - {currentSum}!";
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(winner);
        }
    }
}