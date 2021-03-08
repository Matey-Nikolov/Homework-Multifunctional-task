namespace TEST2021MORE1_1
{
    using System;

    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double volume = Math.PI * (Math.Pow(r, 2) * h);
            Console.WriteLine(volume);
        }
    }
}
