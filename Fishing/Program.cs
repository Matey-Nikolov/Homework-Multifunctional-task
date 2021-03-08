using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int huntingdays = int.Parse(Console.ReadLine());

            int totalfish = 0;
            double money = 0;
            double winlose = 0;
            double tax = 0;
            int a = 0;
            string namefish = "";

            for (int i = 0; i < huntingdays; i++)
            {
                a++;
                namefish = Console.ReadLine();
                if (namefish == "Stop")
                {
                    break;
                }

                double kgfish = double.Parse(Console.ReadLine());

                int length = namefish.Length;
                int sum = 0;
                for (int j = 0; j < length; j++)
                {
                    sum = sum + namefish[j];

                }

                if (a == 3)
                {
                    money = money +(sum / kgfish);
                    a = 0;
                    totalfish++;
                }
                else
                {

                    tax = tax + (sum / kgfish);
                    totalfish++;
                }
            }

            if (money > tax)
            {
                winlose = money - tax;
                if (huntingdays == totalfish)
                    Console.WriteLine("Lyubo fulfilled the quota!");

                Console.WriteLine($"Lyubo's profit from {totalfish} fishes is {winlose:f2} leva.");
            }
            else
            {
                winlose = tax - money;
                Console.WriteLine($"Lyubo lost {winlose:f2} leva today.");
            }


        }
    }
}
