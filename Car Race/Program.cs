namespace Car_Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double leftSum = 0;
            double rigthSum = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            { 
                if (numbers[i] == 0)
                {
                    leftSum *= 0.8;
                }
                if (numbers[numbers.Count - 1 - i] == 0)
                {
                    rigthSum *= 0.8;
                }
                
                leftSum += numbers[i];
                rigthSum += numbers[numbers.Count - 1 - i];
            }

            if (leftSum < rigthSum && Math.Floor(leftSum) == leftSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else if (leftSum < rigthSum && Math.Floor(leftSum) != leftSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum:f1}");
            }
            else if (leftSum > rigthSum && Math.Floor(rigthSum) != rigthSum)
            {
                Console.WriteLine($"The winner is right with total time: {rigthSum:f1}");
            }
            else if (leftSum > rigthSum && Math.Floor(rigthSum) == rigthSum)
            {
                Console.WriteLine($"The winner is right with total time: {rigthSum}");
            }
        }
    }
}
