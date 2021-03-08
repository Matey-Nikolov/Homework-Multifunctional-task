namespace numberreturn
{
    using System;

    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CountDigit(n));

            NumberFormatInfo(n, false); // false
            Console.WriteLine(NumberFormatInfo(n, true));
        }

        static int CountDigit(int number)
        {
            int count = 0; // To do

            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        static int NumberFormatInfo(int number, bool option)
        {
            int count = 0; // To do

            while (number != 0)
            {
                number /= 10;
                count++;
            }


            if (option)
            {
                return count;
            }
            else
            {
                return number;
            }

        }

    }
}
