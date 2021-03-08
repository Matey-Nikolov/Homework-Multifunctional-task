using System;

namespace Най_малко_число
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int min = int.MaxValue; // основа, която да мине първата проверка 

            while (count < n)
            {
                int num = int.Parse(Console.ReadLine());
                count++;
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
