using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int sum = 0;

            int m2 = width * length * height;

            while (m2 >= sum)
            {
                string done = Console.ReadLine();
                if (done == "Done")
                {
                    break;
                }
                else
                {
                    int carton = int.Parse(done);
                    sum = sum + carton;
                }
            }

            if (sum >= m2)
            {
                sum = sum - m2;
                Console.WriteLine($"No more free space! You need {sum} Cubic meters more.");
            }
            else
            {
                sum = m2 - sum;
                Console.WriteLine($"{sum} Cubic meters left.");
            }


        }
    }
}
