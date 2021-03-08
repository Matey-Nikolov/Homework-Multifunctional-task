using System;

namespace Equal_Sums_Left_Right_Position
{
    public class Program
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int fifthDigit = i % 10;
                int fourDigit = (i / 10) % 10;
                int thirdDigit = (i / 100) % 10;
                int secondDigit = (i / 1000) % 10;
                int firstDigit = (i / 10000) % 10;
                int leftSum = firstDigit + secondDigit;
                int rightsum = fourDigit + fifthDigit;
                if (leftSum == rightsum)
                {
                    Console.Write(i + " ");
                }
                else if (Math.Min(leftSum, rightsum) + thirdDigit == Math.Max(leftSum, rightsum))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}