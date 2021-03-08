using System;

namespace шивачен_цех
{
    class Program
    {
        static void Main(string[] args)
        {
            int pravoagalnimasi = int.Parse(Console.ReadLine());
            double dalginamasivmetri = double.Parse(Console.ReadLine());
            double Widthmasses = double.Parse(Console.ReadLine());

          double areatablecloth = pravoagalnimasi * (dalginamasivmetri + 2 * 0.30) * (Widthmasses + 2 * 0.30);
            double areacarriage = pravoagalnimasi * (dalginamasivmetri/2) * (dalginamasivmetri/2);

            double USD = areatablecloth * 7 + areacarriage * 9;
            double BGN = USD * 1.85;

            Console.WriteLine($"{USD:f2} USD");
            Console.WriteLine($"{BGN:f2} BGN");
        }
    }
}
