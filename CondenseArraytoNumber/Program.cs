namespace CondenseArraytoNumber
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] condensed = new int[nums.Length - 1];
            int result = 0;

            if (nums.Length <= 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
                nums[i] = condensed[i];
                for (int a = 0; a < condensed.Length - 1; a++)
                {
                    nums[a] = condensed[a] + condensed[a + 1];
                }

                result = nums[i];
            }
            Console.WriteLine(result);
        }
    }
}
