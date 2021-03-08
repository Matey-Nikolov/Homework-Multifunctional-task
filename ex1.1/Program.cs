namespace ex1._1
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // onция 1 
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                else
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(numbers.Average());
        }
    }
}
