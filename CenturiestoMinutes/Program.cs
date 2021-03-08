
namespace CenturiestoMinutes
{
    using System;

    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            
            int years = ReturnYears(centuries);
            int days = Returndays(years);
            int hours = ReturnHours(days);
            int minutes = ReturnMinutes(hours);
            
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }

        static int ReturnMinutes(int hours)
        {
            int sumMinutes = 0;
            return sumMinutes = hours * 60;
        }

        static int ReturnHours(int days)
        {
            int sumHours = 0;
            return sumHours = days * 24;
        }

        static int Returndays(int years)
        {
            int sumdays = 0;
            return sumdays = (int)(years * 365.2422);
        }

        static int ReturnYears(int centuries)
        {
            int sumYears = 0;
            return sumYears = centuries * 100;
        }
    }
}
