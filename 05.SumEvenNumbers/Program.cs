namespace _05.SumEvenNumbers
{
    using System;
    using System.Linq;
    using System.Runtime.Serialization.Formatters;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                                  .Split(" ")
                                  .Select(x => int.Parse(x))
                                  .ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
