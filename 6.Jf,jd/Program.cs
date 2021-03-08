using System;

namespace _6.Jf_jd
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthcake = int.Parse(Console.ReadLine());
            int lengthcake = int.Parse(Console.ReadLine());

            int dimension = widthcake * lengthcake;

            while (0 <= dimension)
            {
                string stop = Console.ReadLine();

                if (stop == "STOP")
                {
                    break;
                }

                int price = int.Parse(stop);
                dimension = dimension - price;



            }

            if (dimension < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(dimension)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(dimension)} pieces are left.");
            }
        }
    }
}
