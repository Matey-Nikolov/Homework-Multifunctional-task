using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            double budgettravel = 0.0;
            double colectedmoney = 0.0;
            double trvelincome = 0.0;

            string destination = Console.ReadLine();

            while (destination != "End")
            {
                budgettravel = double.Parse(Console.ReadLine());

                while (colectedmoney < budgettravel)
                {
                    trvelincome = double.Parse(Console.ReadLine());
                    colectedmoney = colectedmoney + trvelincome;
                }

                Console.WriteLine($"Going to {destination}!");
                colectedmoney = 0;
                destination = Console.ReadLine();
            }
        }
    }
}

