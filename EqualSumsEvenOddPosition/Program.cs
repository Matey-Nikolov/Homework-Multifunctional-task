using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number; i <= number2; i++)
            {
                string sumnum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int a = 0; a < sumnum.Length; a++)
                {
                    int currentDigit = int.Parse(sumnum[a].ToString());

                    if (a % 2 == 0)
                        evenSum += currentDigit;
                    else
                        oddSum += currentDigit;
                }

                if (oddSum == evenSum)
                    Console.Write(i + " ");
            }


        }
    }
}
