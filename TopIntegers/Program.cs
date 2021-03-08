namespace TopIntegers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] arraysnumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();



            for (int i = 0; i < arraysnumbers.Length - 1; i++)
            {
                int currentNumber = arraysnumbers[i];

                if (currentNumber > arraysnumbers[arraysnumbers.Length - i])
                {
                    Console.WriteLine(arraysnumbers[i]);
                }
            }

        }
    }
}
