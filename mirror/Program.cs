using System;

namespace mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(MirrorNumber(n));
        }


        static int MirrorNumber(int number)
        {
            int mirror = 0;

            while (number != 0)
            {
                mirror = (mirror * 10) + (number % 10);
                number /= 10;
            }

            return mirror;
        }
    }
}
