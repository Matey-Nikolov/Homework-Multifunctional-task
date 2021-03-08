using System;

namespace Най_голямо_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int max = int.MinValue; // основа, която да мине първата проверка 

            while (count < n)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);

        }
    }
}
