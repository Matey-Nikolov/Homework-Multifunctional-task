using System;

namespace _10._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double money = 0;
            double first2 = 0;
            double notenough = 0;

            if (people >= 1 && people <= 4)
            {
                first2 = 0.75 * first;
            }
            else if (people >= 5 && people <= 9)
            {
                first2 = 0.60 * first;
            }
            else if (people >= 10 && people <= 24)
            {
                first2 = 0.50 * first;
            }
            else if (people >= 25 && people <= 49)
            {
                first2 = 0.40 * first;
            }
            else if (people >= 50)
            {
                first2 = 0.25 * first;
            }

            first = first - first2;


            if (category == "VIP")
            {
                money = 499.99 * people;

            }
            else if (category == "Normal")
            {
                money = 249.99 * people;
            }

            if (money < first)
            {
                notenough = money - first;
                Console.WriteLine($"Yes! You have {Math.Abs(notenough):f2} leva left.");
            }
            else if (money > first)
            {
               notenough = money - first;
                Console.WriteLine($"Not enough money! You need {Math.Abs(notenough):f2} leva.");
            }

        }
    }
}
