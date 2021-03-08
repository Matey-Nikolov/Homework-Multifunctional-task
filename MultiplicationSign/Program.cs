using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            PrintNegativePositiveZero(num1, num2, num3);
        }

        static void PrintNegativePositiveZero(int num1, int num2, int num3) 
        {
            int positivenum = 0;

            if (num1 > 0)       // Броя позитивните числа.
                positivenum++;

            if (num2 > 0)
                positivenum++;

            if (num3 > 0)
                positivenum++;

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                if (positivenum % 2 == 0)
                    Console.WriteLine("negative");
                else
                    Console.WriteLine("positive");
            }


        }
    }
}
