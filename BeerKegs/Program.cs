namespace BeerKegs
{
    using System;

    class Program 
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

                PrintBiggestKeg(numbers);
        }

        static void PrintBiggestKeg(int numbers)
        { 
            string nameKeg = "";

            double volume1 = 0;
            double volume2 = 0;

            while (numbers > 0)
            {
                string modelKeg1 = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume1 = Math.PI * Math.Pow(radius, 2) * height;

                if (volume1 >= volume2)
                {
                    volume2 = volume1;
                    nameKeg = modelKeg1;
                }
                numbers--;
            }
            Console.WriteLine(nameKeg);
        }
    }
}
