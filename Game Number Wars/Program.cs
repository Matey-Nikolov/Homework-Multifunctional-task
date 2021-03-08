using System;

namespace Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();

            int coutername = 0;
            int coutername2 = 0;
            string stop = "";

            int numbername = 0;
            int numbername2 = 0;

            while (stop != "End of game")
            {
                stop = Console.ReadLine();
                if (stop == "End of game")
                {
                    Console.WriteLine($"{name} has {coutername} points");
                    Console.WriteLine($"{name2} has {coutername2} points");
                    break;
                }
                else
                {
                    numbername = int.Parse(stop);
                }

                numbername2 = int.Parse(Console.ReadLine());

                if (numbername > numbername2)
                {
                    coutername = coutername + (numbername - numbername2);
                }
                else
                {
                    coutername2 = coutername2 + (numbername2 - numbername);
                }

                if (numbername == numbername2)
                {
                    Console.WriteLine($"Number wars!");

                    numbername = int.Parse(Console.ReadLine());
                    numbername2 = int.Parse(Console.ReadLine());

                    if (numbername > numbername2)
                    {
                        Console.WriteLine($"{name} is winner with {coutername} points");
                    }
                    else
                    {
                        Console.WriteLine($"{name2} is winner with {coutername2} points");
                    }
                    break;
                }
            }
        }
    }
}
