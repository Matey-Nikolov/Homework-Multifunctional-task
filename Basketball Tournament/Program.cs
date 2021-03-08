using System;

namespace Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameoftournament = Console.ReadLine();
            double numberofmatches = double.Parse(Console.ReadLine());

            int total = 0;

            int countergame = 0;
            double countergamewin = 0;
            double countergamelosses = 0;

            double numberofwins = 0.0;
            double numberoflosses = 0.0;

            while (nameoftournament != "End of tournaments")
            {



                for (int i = 0; i < numberofmatches; i++)
                {
                    int pointsscoredbyDesiteam = int.Parse(Console.ReadLine());
                    int pointsscoredbytheopposingteam = int.Parse(Console.ReadLine());

                    countergame++;

                    if (pointsscoredbyDesiteam > pointsscoredbytheopposingteam)
                    {
                        countergamewin++;
                        total = pointsscoredbyDesiteam - pointsscoredbytheopposingteam;
                        Console.WriteLine($"Game {countergame} of tournament {nameoftournament}: win with {total} points.");
                    }
                    else
                    {
                        countergamelosses++;
                        total = pointsscoredbytheopposingteam - pointsscoredbyDesiteam;
                        Console.WriteLine($"Game {countergame} of tournament {nameoftournament}: lost with {total} points.");

                    }

                    //  if (countergame < numberofmatches)
                    //  {
                    //      pointsscoredbyDesiteam = int.Parse(Console.ReadLine());
                    //     pointsscoredbytheopposingteam = int.Parse(Console.ReadLine());
                    //  }

                }

                countergame = 0;
                numberofmatches = countergamewin + countergamelosses;

                nameoftournament = Console.ReadLine();
                if (nameoftournament == "End of tournaments")
                {
                    numberofwins = countergamewin / numberofmatches * 100.0;
                    numberoflosses = countergamelosses / numberofmatches * 100.0;

                    Console.WriteLine($"{numberofwins:f2}% matches win");
                    Console.WriteLine($"{numberoflosses:f2}% matches lost");
                    break;
                }

                numberofmatches = int.Parse(Console.ReadLine());
            }
        }
    }
}
