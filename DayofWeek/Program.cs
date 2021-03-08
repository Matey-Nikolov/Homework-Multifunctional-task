namespace DayofWeek
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] daysOfWeek = new string[7];

            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            int input = int.Parse(Console.ReadLine());

            if (input < 8 && input > 0)
                Console.WriteLine(daysOfWeek[input - 1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
