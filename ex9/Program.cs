namespace ex9
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] num = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

           Console.WriteLine(InsertionSort(num));
        }

        static int[] InsertionSort(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                int number = num[i];
                int index = i;
                while (index > 0 && num[index - 1] >= number)
                {
                    num[index] = num[index - 1];
                    index--;
                }
                num[index] = number;
            }
            return num;
        }
    }
}
