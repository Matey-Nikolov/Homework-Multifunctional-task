namespace RefactorSpecialNumbers
{
    using System;

    class Program
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            
            bool isSpecialNum1 = false;
            bool isSpecialNum2 = true;

            for (int i = 1; i <= number; i++)
            {
                int sumDigits = 0;
                int digits = i;


                while (digits > 0)
                {
                    sumDigits += digits % 10;
                    digits = digits / 10;
                }

                if (isSpecialNum1 = sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                    Console.WriteLine("{0} -> {1}", i, isSpecialNum1);
                else
                    Console.WriteLine("{0} -> {1}", i, isSpecialNum1);
            }
        }
    }
}
