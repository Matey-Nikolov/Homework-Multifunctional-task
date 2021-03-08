using System;
using System.Collections.Generic;
using System.Linq;

namespace TEST2021_7
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(YesOrNoSort(numbers)); //-23 0 2 56 1
        }

        static string YesOrNoSort(List<int> numbers)
        {
            string yes = "Yes";
            string no = "No";

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return no;
                }
            }

            return yes;
        }
    }
}
