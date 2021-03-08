using System;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberofsteps = double.Parse(Console.ReadLine());
            double numberofdancers = double.Parse(Console.ReadLine());
            double numberofdaystostudy = double.Parse(Console.ReadLine());


            double percentageofstepsforeachday = Math.Ceiling((numberofsteps / numberofdaystostudy) / numberofsteps * 100);
            double percentageofstepsforeachdancer = percentageofstepsforeachday / numberofdancers;


          //  Console.WriteLine($"{percentageofstepsforeachday}%");
          //  Console.WriteLine($"{percentageofstepsforeachdancer}%");

            if (percentageofstepsforeachday <= 13 ) {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentageofstepsforeachdancer:f2}%.");
            }else
            {
                Console.WriteLine($"No, they will not succeed in that goal! Required {percentageofstepsforeachdancer:f2}% steps to be learned per day.");
            }
        }
    }
}
