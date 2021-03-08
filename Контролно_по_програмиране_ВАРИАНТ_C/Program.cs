using System;

namespace Контролно_по_програмиране_ВАРИАНТ_C
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(VolumeStraightRoundCone(5, 5));
        }

        static double VolumeStraightRoundCone(double r, double h)
        {
            double volume = 1.0 / 3.0 * Math.PI * Math.Pow(r, 2) * h;
            return volume;
        }
    }
}
