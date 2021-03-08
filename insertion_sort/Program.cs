namespace insertion_sort
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 10, 5, 5, 99, 3, 4, 2, 5, 1, 1, 4 };

            InsertionSort(array);
            Console.WriteLine(string.Join(" - ", array));
        }



        static void InsertionSort(int[] arr)
        {
            int holePos;
            int valueToInsert;

            for (int i = 1; i < arr.Length; i++)
            {
                valueToInsert = arr[i];
                holePos = i;

                while (holePos > 0 && arr[holePos - 1] > valueToInsert)
                {
                    arr[holePos] = arr[holePos - 1];
                    holePos++;
                }

                arr[holePos] = valueToInsert;
            }

        }

    }
}
