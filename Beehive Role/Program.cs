using System;

namespace Beehive_Role
{
    class Program
    {
        static void Main(string[] args)
        {
            int intellect = int.Parse(Console.ReadLine());   //
            int force = int.Parse(Console.ReadLine());      // Въвеждаме силата, интелигентносста и пола на пчелата.
            string nol = Console.ReadLine();               //

            string role = "";  // Прислояваме ролята на всяка пчела.

            switch (nol) // Проверяваме дали има значение ролята от пола.
            {
                case "female":
                    if (force >= 80 && intellect >= 80) // Проверяваме дали може да стане кралица.
                    {                                  // Оттук до долу провеляваме за всяка една роля.
                        role = "Queen Bee";           //
                        break;                  
                    }
                    if (intellect >= 80)                               
                    {
                        role = "Repairing Bee";
                        break;
                    }
                    else if (intellect >= 60)
                    {
                        role = "Cleaning Bee";
                        break;
                    }

                    if (force >= 60)
                    {
                        role = "Guard Bee";
                        break;
                    }
                    role = "Worker Bee";
                    break;
                                                 // Оттук до долу провеляваме за всяка една роля.
                case "male":                    // Проверяваме за мъжкия пол, ролите.
                    if (force >= 80)
                    {
                        role = "Drone Bee";
                        break;
                    }

                    if (intellect >= 80)
                    {
                        role = "Repairing Bee";
                        break;
                    }
                    else if (intellect >= 60)
                    {
                        role = "Cleaning Bee";
                        break;
                    }

                    if (force >= 60)
                    {
                        role = "Guard Bee";              
                        break;                          
                    }
                                                        //
                    role = "Worker Bee";               //
                    break;                            //
            }

            Console.WriteLine(role); // Отпечатваме ролята.
        }
    }
}
