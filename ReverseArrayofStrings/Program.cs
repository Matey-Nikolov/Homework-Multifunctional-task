namespace ReverseArrayofStrings
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                                    .Split(" ")
                                    .ToArray();

            //input = input.Reverse().ToArray(); // Нещо като празна колекция.
            // Console.WriteLine(string.Join(" ", input));

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
