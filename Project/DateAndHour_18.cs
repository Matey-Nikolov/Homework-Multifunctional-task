using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Project
{
    class DateAndHour_18
    {
        public string PrintDateAfterHours()
        {
            // 18
            // string text = "11.01.2001 22:00:00";
            // string format = "dd.MM.yyyy HH:mm:ss";
            Console.Write("Enter a date and hours (dd.mm.yyyy hh:mm:ss): ");
            string text = Console.ReadLine();
            Console.Write("Enter a format: ");
            string format = Console.ReadLine();

            DateTime parsedDate = DateTime.ParseExact(text, format, CultureInfo.InvariantCulture);

            parsedDate = parsedDate.AddHours(6);
            parsedDate = parsedDate.AddMinutes(30);

            return $"Day: {parsedDate.Day}\nMonth: {parsedDate.Month}\nYear: {parsedDate.Year}\n TimeofDay:{parsedDate.TimeOfDay}";
        }
    }
}