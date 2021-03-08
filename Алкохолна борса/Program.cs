using System;

namespace Алкохолна_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeylv = double.Parse(Console.ReadLine());
            double beerL = double.Parse(Console.ReadLine());
            double wineL = double.Parse(Console.ReadLine());
            double brandyL = double.Parse(Console.ReadLine());
            double whiskeyL = double.Parse(Console.ReadLine());

            double brandylv = whiskeylv / 2;
            double winelv = brandylv - (0.4 * brandylv);
            double beerlv = brandylv - (0.8 * brandylv);
            
            double sumbrandy = brandyL * brandylv;
            double sumwine = wineL * winelv;
            double sumbeer = beerlv * beerL;
            double sumwhiskey = whiskeyL * whiskeylv;

            double totalsum = sumbrandy + sumwine + sumbeer + sumwhiskey;

            Console.WriteLine($"{totalsum:f2}");


        }
    }
}