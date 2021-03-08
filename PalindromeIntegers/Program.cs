
namespace PalindromeIntegers
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            MirrorNumber(n);
        }

        static void MirrorNumber(int number)
        {
            int mirror = 0;
            int n2 = 0;
            string s = number.ToString();

            while (s != "END")
            {
                number = int.Parse(s);

                n2 = number;
                while (number > 0)
                {
                    mirror = (mirror * 10) + (number % 10);
                    number /= 10;
                }

                if (n2 == mirror)
                {
                    Console.WriteLine("true");
                    mirror = 0;
                }
                else
                {
                    Console.WriteLine("false");
                    mirror = 0;
                }
                s = Console.ReadLine();
            }

        }
    }
}
