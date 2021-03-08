namespace масивизадача2
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
            {
                double temp;
                do
                {
                     temp = double.Parse(Console.ReadLine());
                }
                while (temp < 2 || temp > 6);
                nums[i] = temp;
            }

            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            double avg = sum / nums.Length;
            Console.WriteLine("Average: {0:f2}", avg);
        }
    }
}
