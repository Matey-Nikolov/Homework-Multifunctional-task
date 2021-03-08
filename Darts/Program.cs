using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string gamename = Console.ReadLine();

            int points = 301;
            string SingleDoubleTripleRetire = "";
            int successfulshots = 0;
            int unsuccessfulshots = 0;

            while (SingleDoubleTripleRetire != "Retire")
            {
                SingleDoubleTripleRetire = Console.ReadLine();
                if (SingleDoubleTripleRetire == "Retire")
                {
                    Console.WriteLine($"{gamename} retired after {unsuccessfulshots} unsuccessful shots.");
                    break;
                }

                int point = int.Parse(Console.ReadLine());

                switch (SingleDoubleTripleRetire)
                {
                    case "Single":
                        point = point * 1;
                        if (point <= points)
                        {
                            points = points - point;
                            successfulshots++;
                        }
                        else
                        {
                            unsuccessfulshots++;
                        }
                        break;
                    case "Double":
                        point = point * 2;
                        if (point <= points)
                        {
                            points = points - point;
                            successfulshots++;
                        }
                        else
                        {
                            unsuccessfulshots++;
                        }
                        break;
                    case "Triple":
                        point = point * 3;
                        if (point <= points)
                        {
                            points = points - point;
                            successfulshots++;
                        }
                        else
                        {
                            unsuccessfulshots++;
                        }
                        break;
                }

                if (points == 0)
                {
                    Console.WriteLine($"{gamename} won the leg with {successfulshots} shots.");
                    break;
                }
            }
        }
    }
}
