using System;
using System.Globalization;

namespace Date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            // 18
            //
            //

            string text = "11.01.2001 22:00:00";
            string format = "dd.MM.yyyy HH:mm:ss";
            DateTime parsedDate = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);
            Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}\n TimeofDay:{3}",
            parsedDate.Day, parsedDate.Month, parsedDate.Year, parsedDate.TimeOfDay);

            parsedDate = parsedDate.AddHours(6);
            parsedDate = parsedDate.AddMinutes(30);
            Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}\n TimeofDay:{3}",
              parsedDate.Day, parsedDate.Month, parsedDate.Year, parsedDate.TimeOfDay);
        }
    }
}
