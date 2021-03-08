using System;

namespace цикли // познай числото
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNum = rand.Next(1, 100);
            int n = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == randomNum)
                {
                    n++;
                    Console.WriteLine("BRAVO!!!" + n);
                    break;
                }
                else if (randomNum > num)
                {
                    Console.WriteLine("UP");
                    n++;
                }
                else
                {
                    Console.WriteLine("DOWN");
                    n++;
                }
            }

        }
    }
}
