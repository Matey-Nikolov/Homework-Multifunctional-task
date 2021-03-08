using System;

namespace Area_of_Figuresd
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());

                double sideB = double.Parse(Console.ReadLine());

                area = sideA * sideB;

            }
            else if (shape == "circle")
            {
                double sideC = double.Parse(Console.ReadLine());
            }
            else if (shape == "triangle")
            {
                double sidev = double.Parse(Console.ReadLine());
                double sideh = double.Parse(Console.ReadLine());

                area = (sidev * sideh) / 2.0;
            }

            Console.WriteLine(area);
        }
    }
}
