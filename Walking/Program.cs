using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int not = 0;

            while (steps < 10000)
            {
                string home = Console.ReadLine();
                if (home == "Going home")
                {
                    steps = steps + int.Parse(Console.ReadLine());

                    if (steps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                    }
                    else
                    {
                        not = 10000 - steps;
                        Console.WriteLine($"{not} more steps to reach goal.");
                    }
                    break;
                }
                else
                {
                    steps += int.Parse(home);
                    if (steps >= 10000)
                        Console.WriteLine("Goal reached! Good job!");
                }
            }
        }
    }
}
