using System;

namespace Beehive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());  // Въвеждам началната популация на пчелите.
            int years = int.Parse(Console.ReadLine());      //  Въвеждам годините.

            int deadbees = 0;   // Правя си две нови променливи.
            int counter = 0;   //

            for (int i = 0; i < years; i++)                     // Един for за годините се върти.
            {
                population = population + (population / 10) * 2;    // Колко са се родили.
                counter++;                                         // Брояч за всяка една година.
                if (counter == 5)                                 //  На всеки пет години част от пчелите мигрирали.
                {
                    counter = 0;
                    population = population - (population / 50) * 5;
                }
                
                deadbees = population - ((population / 20) * 2);    // Накрая на годините колко са загинали.
                population = deadbees;                             // Прислоявам след смъртта на пчелите, колко са останали. 
            }
            // Отпечатва се каква е популацията след края на for-цикъла. 
            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
