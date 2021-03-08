using System;

namespace akvariym
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            double pr = double.Parse(Console.ReadLine());

            int obem = H * D * W;
            double obemLitri = obem * 0.001;
            double pro = pr * 0.01;
            double realno = obemLitri * (1 - pro);

            Console.WriteLine($"{realno:f3}cm3");
        }
    }
}
