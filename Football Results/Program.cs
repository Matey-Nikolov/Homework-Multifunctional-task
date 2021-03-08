using System;

namespace Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {


            int win = 0;
            int lost = 0;
            int draw = 0;

            for (int i = 0; i < 3; i++)
            {
                string resultofthefirstmatch = Console.ReadLine();
                if (resultofthefirstmatch[0] < resultofthefirstmatch[2])
                {
                    lost++;
                }
                else if (resultofthefirstmatch[0] > resultofthefirstmatch[2])
                {
                    win++;
                }
                else
                {
                    draw++;
                }
            }


            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {draw}");
        }
    }
}