using System;

namespace Зала_за_танци
{
    class Program
    {
        static void Main(string[] args)
        {

            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double areahall = L *  W * 10000;
            double wardrobe = A * A * 10000;
            double bench = areahall / 10;
            double freearea = areahall - wardrobe - bench;
            double persons = freearea / (40 + 7000);
                
            Console.WriteLine($"{Math.Floor(persons)}");
        }
    }
}
