using System;

namespace Beehive_Defense
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberofbees = double.Parse(Console.ReadLine());  // Брой пчели.
            double health = double.Parse(Console.ReadLine());       //  Брой здраве. 
            double attack = double.Parse(Console.ReadLine());      //   Атаката на мечката.

          //  double warbeer = 0;
          //  double counterattackbees = 0;
           // double winorloses = 0;

            while (true)
            {
                numberofbees = numberofbees - attack;                 // Пресмятаме атаката на мечката.

                if (numberofbees < 100)                  // Проверяваме дали на мечката и е оставила живот и пчелите дали са по - малко от сто.
                {
                    if(numberofbees < 0) numberofbees = 0;
                    Console.WriteLine($"The bear stole the honey! Bees left {numberofbees}.");
                    break;
                }

                health = health - (numberofbees * 5);     //  Колко пчели са останали и повторната                    
                                                         //    атака.

                if (health < 0)    
                {
                    Console.WriteLine($"Beehive won! Bees left {numberofbees}.");
                    break;
                }
            }
        }
    }
}
