namespace Mathnumbereven
{
    using System;

    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            int even = GetEvenNumber(number);
            Console.WriteLine(even);

            int odd = GetOddNumber(number);
            Console.WriteLine(odd);

            int sum = SumNumbers(even, odd);
            Console.WriteLine(sum);
        }

        static int GetEvenNumber(string number)
        {

            int sumEven = 0;

            for (int i = 0; i <= number.Length; i++)
            {
                if (i % 2 == 0)
                    sumEven = sumEven + i;
            }
            return sumEven;
        }

        static int GetOddNumber(string number)
        {
            int sumOdd = 0;

            for (int i = 0; i <= number.Length; i++)
            {
                if (i % 2 != 0)
                    sumOdd = sumOdd + i;
            }
            return sumOdd;
        }

        static int SumNumbers(int sumEven, int sumOdd)
        {
            int sumNumber = sumEven * sumOdd;
            return sumNumber;
        }
    }
}
