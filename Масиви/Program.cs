using System;

namespace Масиви
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] numbers = { 10, 20, 5, -9, 0, 2 };
            // numbers[1] = 999;
            for (int i = 0; i <= numbers.Length - 1; i++) // махаме -1, НЕ РАБОТИ
            {
                Console.WriteLine(numbers[i]);
            }

            string[] students = {"Gosho", "Stavri", "Stamat", "Anka"};
            for (int i = 0; i <= students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            */


            // empty array
            int[] nums = new int[10];
            string[] towns = new string[5];
            double[] marks = new double[27];

            nums[8] = 200;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
