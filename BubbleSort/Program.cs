using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 5, 99, 3, 4, 2, 5, 1, 1, 4 };
            
            BubbleSort(array);

        }

        static void BubbleSort(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                bool flag = false;

                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        flag = true;
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                if (!flag)
                    break;
            }
            Console.WriteLine(arr);
        }
    }
}
