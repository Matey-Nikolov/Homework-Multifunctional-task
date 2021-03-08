namespace Aex6
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
           // Console.WriteLine(IsPowerOfTen(100));
        }

        //B ex 6
        static double GetAverage(int[] array)
        {
            return array.Sum();
        }

        //B ex 5
        static bool IsPowerOfTen(int number)
        {
            if (number % 10 == 0)
            {
                return true;
            }
            return false;
        }

        //A ex powerof 2
        static bool IsPowerOfTwo(int x)
        {
            //return (x & (x - 1)) == 0;
            // 8 == 1000
            // 7 == 0111
           // 16 == 10000
           // 15 == 01111
                 // 00000
           // 14 == 01110
           //       01110
            while (true)
            {
                x = x / 2;
                if (x == 2)
                {
                    return true;
                }
                else if (x < 2)
                {
                    return false;
                }
            }
        }

    }
}
