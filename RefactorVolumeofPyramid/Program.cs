namespace RefactorVolumeofPyramid
{
    using System;

    class Program
    {
        static void Main()
        {
            /*
            int length = 0;
            int width = 0;
            int heigth = 0;
            int volume = 0;
            int volumesum = 0;

            Console.WriteLine($"Length: ");
            length = int.Parse(Console.ReadLine());

            Console.WriteLine($"Width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine($"Heigth: ");
            heigth = int.Parse(Console.ReadLine());

            volume = int.Parse(Console.ReadLine());
            volumesum = (length * heigth * volume) / 3;
            Console.WriteLine($"Pyramid Volume: {volumesum:f2}");
            */
            double Length, Height, all, Volume = 0;
            Console.Write("Length: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            Height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Volume = double.Parse(Console.ReadLine());
            all = (Length * Height * Volume) / 3;
            Console.Write($"Pyramid Volume: {all:f2}");

        }
    }
}
