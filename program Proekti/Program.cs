using System;

namespace program_Proekti
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int proekti = int.Parse(Console.ReadLine());
            int hours = proekti * 3;

            Console.WriteLine($"The architect {name} will need {hours}  hours to complete {proekti} projects.");
           
        }
    }
}