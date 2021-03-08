using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Char_String_Mega
{
    class _17DateTime
    {

        public string numberOfDaysBetweenThem()
        {
            Console.Write("Wtrite date: ");
            int[] firstDate = Console.ReadLine()
                .Split(".", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.Write("Wtrite second date: ");
            int[] secondtDate = Console.ReadLine()
                .Split(".", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int day1 = firstDate[0];
            int month1 = firstDate[1];
            int year1 = firstDate[2];

            int day2 = secondtDate[0];
            int month2 = secondtDate[1];
            int year2 = secondtDate[2];


            DateTime start = new DateTime(2010, 6, 14);
            DateTime end = new DateTime(2016, 08, 14);
            TimeSpan difference = end - start;

            string a = $"Distance: {difference.Days}  days";
            return a;
        }
    }
}