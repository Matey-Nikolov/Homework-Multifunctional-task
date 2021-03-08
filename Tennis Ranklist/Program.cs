using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbertournamentsparticipated = int.Parse(Console.ReadLine());
            double initialnumberofpoints = int.Parse(Console.ReadLine());

            double numberofwon = 0;
            double averagepointsearned = 0;
            double percentageoftournamentswon = 0.0;

            double initialnumberofpoints2 = initialnumberofpoints;

            for (int i = 0; i < numbertournamentsparticipated; i++)
            {
                string Reachedastageofthetournament = Console.ReadLine();

                switch (Reachedastageofthetournament)
                {
                    case "W":
                        initialnumberofpoints = initialnumberofpoints + 2000;
                        numberofwon++;
                        break;
                    case "F": initialnumberofpoints = initialnumberofpoints + 1200; break;
                    case "SF": initialnumberofpoints = initialnumberofpoints + 720; break;
                }

            }

            averagepointsearned = (initialnumberofpoints - initialnumberofpoints2) / numbertournamentsparticipated;

            percentageoftournamentswon = (numberofwon / numbertournamentsparticipated) * 100.0;

            Console.WriteLine($"Final points: {Math.Floor(initialnumberofpoints)}"); //Math.Floor
            Console.WriteLine($"Average points: {Math.Floor(averagepointsearned)}");
            Console.WriteLine($"{percentageoftournamentswon:f2}%");
        }
    }
}
