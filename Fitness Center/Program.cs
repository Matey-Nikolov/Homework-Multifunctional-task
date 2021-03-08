using System;

namespace Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int Firstrow = int.Parse(Console.ReadLine());


            int Back = 0;
            int Chest = 0;
            int Legs = 0;
            int Abs = 0;

            int Proteinshake = 0;
            int Proteinbar = 0;

            double Workout = 0;
            double Protein = 0;

            for (int i = 0; i < Firstrow; i++)
            {
                string Theactivityinthegym = Console.ReadLine();

                switch (Theactivityinthegym)
                {
                    case "Back": Back++; break;
                    case "Chest": Chest++; break;
                    case "Legs": Legs++; break;
                    case "Abs": Abs++; break;

                    case "Protein shake": Proteinshake++; break;
                    case "Protein bar": Proteinbar++; break;
                }

                Protein = (Proteinshake + Proteinbar) * 100.0 / Firstrow;
                Workout = (Back + Chest + Legs + Abs) * 100.0 / Firstrow;
            }


            Console.WriteLine($"{Back} - back");
            Console.WriteLine($"{Chest} - chest");
            Console.WriteLine($"{Legs} - legs");
            Console.WriteLine($"{Abs} - abs");
            Console.WriteLine($"{Proteinshake} - protein shake");
            Console.WriteLine($"{Proteinbar} - protein bar");
            Console.WriteLine($"{Workout:f2}% - work out");
            Console.WriteLine($"{Protein:f2}% - protein");
        }
    }
}
