namespace ex5
{
    using System;

    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnBy10(numbers));
        }

        static bool ReturnBy10(int numbers)
        {
            bool sum = true;
            if ((numbers * numbers) % 10 == 0)
            {
                sum = true;
            }
            else
            {
                sum = false;
            }
            return sum;
        }
    }
}

