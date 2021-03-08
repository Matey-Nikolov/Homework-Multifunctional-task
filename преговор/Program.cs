using System;

namespace преговор
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine(min);
        }
    }
}
