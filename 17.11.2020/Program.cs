namespace _17._11._2020
{
    using System;

    class Program
    {
        static void Main()
        {
            int[] array = { 10, 5, 5 ,99, 3, 4, 2, 5, 1, 1, 4 };

            bool flag = false;

            for (int i = 1; i < array.Length - 1; i++)
            {
                int leftSum = 0;

                for (int j = 0; j < i; j++)// <= i - 1
                {
                    leftSum += array[j];
                }

                int rightSum = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    flag = true;
                    Console.WriteLine("array[{0}] = [{1}]", i, array[i]);
                }
            }

            if (!flag)
            {
                Console.WriteLine();
            }
        }
    }
}
