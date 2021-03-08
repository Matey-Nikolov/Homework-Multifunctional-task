using System;

namespace оператор_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num > 100)

                    Console.WriteLine("Infinite loop");
                break;
            }
        }

    }
}

