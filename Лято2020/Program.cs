using System;

namespace Лято2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofbatches = int.Parse(Console.ReadLine());
            bool flour = false;
            bool sugar = false;
            bool eggs = false;
            
            for (int i = 1; i <= numberofbatches; i ++)
            {
                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "Bake!")
                    {
                        if (flour == true && sugar == true && eggs == true)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                             flour = false;
                             sugar = false;
                             eggs = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            continue;
                        }
                        switch (command)
                        {
                            case "flour": flour = true; break;
                            case "eggs": eggs = true; break;
                            case "sugar": sugar = true; break;
                        }
                    }
                }
            }
        }
    }
}
