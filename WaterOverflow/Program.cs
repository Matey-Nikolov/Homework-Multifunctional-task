namespace WaterOverflow
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BarrelFilling(n);
        }

        private static void BarrelFilling(int n)
        {
            int waterTank = 255;
            int fullTank = 0;
            
            for (int i = 0; i < n; i++)
            {
                int quantitiesWater = int.Parse(Console.ReadLine());


                fullTank = fullTank + quantitiesWater;

                if (fullTank > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    fullTank = fullTank - quantitiesWater;
                }
                else
                {
                    fullTank = fullTank;
                }

            }
            Console.WriteLine(fullTank);
        }
    }
}
