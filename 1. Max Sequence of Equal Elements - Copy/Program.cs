namespace _1._Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int count2 = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count = i;
                    if (count > count2)
                    {
                        count = count2;
                        numbers[i];

                    }

                }
            }

        }
    }
}
