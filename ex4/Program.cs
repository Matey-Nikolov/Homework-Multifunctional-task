namespace ex4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());
           Console.WriteLine(ReturnSum(numbers));
        }

        static int ReturnSum(int numbers)
        {
            int sum = 0;
            while (numbers != 0)
            {
                sum = sum + (numbers % 10);
                numbers = numbers /10;
            }
            return sum;
        }
    }
}
