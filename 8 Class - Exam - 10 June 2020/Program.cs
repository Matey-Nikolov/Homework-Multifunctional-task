using System;

namespace _8_Class___Exam___10_June_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberbees = double.Parse(Console.ReadLine());     // Въвежда ме си броя пчели и цветя.
            double numberflowers = double.Parse(Console.ReadLine()); //  

            double honey = (numberbees * numberflowers) * 0.21;  //  Произведен общо мед.
            double honeycombs = honey / 100.0;                  //  Колко са медните пити.

            double honeyost = honey % 100;  // Калко мед е останало.

            // Това се извежда след направените прости сметки.
            Console.WriteLine($"{Math.Floor(honeycombs)} honeycombs filled.");
            Console.WriteLine($"{honeyost:f2} grams of honey left."); 
        }
    }
}
