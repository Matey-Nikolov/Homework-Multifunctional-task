namespace масиви2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 5, -9, 0, 2, 99 };
            // numbers[1] = 999;
            for (int i = 0; i < numbers.Length ; i++) // махаме -1, НЕ РАБОТИ
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Reverse: ");

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
