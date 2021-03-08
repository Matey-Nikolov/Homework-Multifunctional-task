using System;

namespace Pregovor
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyforWinter = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string thename = "";

            double honey = 0;
            double nosene = 0;
            double ostatyk = 0;
            double izqdenMed = 0;
            string finalwords = "";



            while (name != "Winter has come")
            {

                for (int times = 1; times <= 6; times++)
                {
                    nosene = double.Parse(Console.ReadLine());

                    if (nosene < 0)
                    {
                        nosene = nosene * -1;
                        honey = honey - nosene;
                        izqdenMed = izqdenMed + nosene;


                        if (izqdenMed >= honey)
                        {
                            thename = name;
                        }

                    }
                    else if (nosene >= 0)
                    {
                        honey = honey + nosene;

                    }

                    if (times == 6)
                    {
                        if (izqdenMed >= honey)
                        {
                            finalwords = thename + " was banished for gluttony";

                        }
                        break;
                    }

                }
                name = Console.ReadLine();
            }

            if (honey >= honeyforWinter && izqdenMed < honey)
            {
                ostatyk = honey - honeyforWinter;
                Console.WriteLine($"Well done! Honey surplus {ostatyk:F2}.");
            }

            else if (honey < honeyforWinter && finalwords != "")
            {
                Console.WriteLine(thename + " was banished for gluttony");
                ostatyk = honeyforWinter - honey;
                Console.WriteLine($"Hard Winter! Honey needed {ostatyk:F2}.");

            }

            else if (honey < honeyforWinter && finalwords == "")
            {
                ostatyk = honeyforWinter - honey;
                Console.WriteLine($"Hard Winter! Honey needed {ostatyk:F2}.");
            }

        }
    }
}