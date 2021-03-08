namespace масив_задача
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double[] nums = new double[n]; // create array whith n elements

            // read values for array
            for (int i = 0; i < nums.Length; i++)
                nums[i] = double.Parse(Console.ReadLine());

            // x10
            for (int i = 0; i < nums.Length; i++)
                nums[i] *= 10;

            // printing...
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine("nums [{0}] = {1}", i, nums[i]);
        }
    }
}
