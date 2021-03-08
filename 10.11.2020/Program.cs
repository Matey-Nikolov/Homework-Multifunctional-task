namespace _10._11._2020
{
    using System;

    class Program
    {
        static void Main()
        {   /*
            for (int i = 1; i <= 100; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + ", ");
                
            }
            */
            /*
            for(int i = 1; i <= 10000; i++)
            {
                if (IsPowerOf2(i))
                {
                    Console.WriteLine(i);
                }
            }
            */

            int num1 = 5;
            int num2 = 7
                ;
            int result = num1 & num2;
            Console.WriteLine(result);
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            
            for (int i = 2; i * i <= number; i++)
            {
                if (number % 2 == 0)
                    return false;
            }
            return true;
        }


        static bool IsPowerOfTwo(int number)
        {
            if (number < 1)
            {
                return false;
            }

            int n = 1;

            do
            {
                if (number == n)
                {
                    return true;
                }
                n *= 2;
            }
            while (n <= number);

            return false;
        }

       static bool IsPowerOf2(int number)
       {
            return (number >= 1) && ((number & (number - 1)) == 0);
       }
    }
}
