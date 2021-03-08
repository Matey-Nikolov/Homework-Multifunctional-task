namespace EqualArrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int[] arr2 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            Arrays(arr1, arr2);
        }

         static void Arrays(int[] arr1, int[] arr2)
         {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                
                if (arr1[i] != arr2[i])
                {

                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    counter++;
                    break;
                }
                else
                {
                    sum = arr1[i] + arr2[i];

                }
            }

            if(counter != 1)
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

         }
    }
}
