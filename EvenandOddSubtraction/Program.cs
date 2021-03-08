namespace EvenandOddSubtraction
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenNumbers = GetEvenNumbers(numbers);
            int oddNumbers = GetOddNumbers(numbers);

            int defferene = evenNumbers - oddNumbers;
            Console.WriteLine(defferene);
        }

        private static int GetOddNumbers(int[] numbers)
        {
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 != 0)
                {
                    oddSum += currentNumber;
                }
            }
            return oddSum;
        }

        static int GetEvenNumbers(int[] numbers)
        {
            int evenSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
            }
            return evenSum;
        }
    }
}
