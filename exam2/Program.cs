using System;
using System.Linq;

namespace exam2
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();


            int[] sort = SortArrayInsertionSort(arr);
                Console.WriteLine(string.Join(" ", sort));
        }


        static int[] SortArrayInsertionSort(int[] arr)
        {
            int key = 0;

            for (int i = 1; i < arr.Length; ++i)
            {
                key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j] = arr[j + 1];
                    j = j - 1;
                }
                key = arr[j + 1];
            }
            return arr;
        }
    }
}
