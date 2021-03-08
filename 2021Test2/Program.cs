using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] metod = Console.ReadLine()
                .Split(" ").
                Select(int.Parse)
                .ToArray();


            Console.WriteLine(SelectionSort(metod));
        }

        static int[] SelectionSort(int[] a)
        {
            int n = a.Length;
            int v = 0;

            for (int j = 0; j < n - 1; j++)
            {
                int iMin = j;
                for (int i = j + 1; i < n; i++)
                {
                    if (a[i] < a[iMin])
                    {
                        iMin = i;
                    }
                }
                if (iMin != j)
                {
                    int x = a[j];
                    a[j] = a[iMin];
                    a[iMin] = x;

                }
            }
            return v;
        }
    }
}