using System;

namespace array
{
    class Program
    {
        static void Main()
        {   /*
            int[] arr1 = {1,2,10,8 };
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            arr2[0] = 99;
            arr2[1] = 100;

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
            */

            int[] nums = { 2, 3, 4 }; 
            Change(nums);
            Console.WriteLine(nums[0]);
        }

        static void Change(int[] arr)// по референция ref
        {
            int[] copyarr = new int[arr.Length];
            for (int i = 0; i < copyarr.Length; i++)
            {
                copyarr[i] = arr[i];
            }
            copyarr[0]++;
        }
    }
}
