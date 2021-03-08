using System;

namespace _10._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
             
            double price = 0;                   //цена апартамент 
            double Studio = 0;                 // цена студио 

            switch (month)                     //базова цена 
            {
                case "May":
                case "October":
                    Studio = day * 50.0;
                    price = day * 65.0;
                    break;
                case "June":
                case "September":
                    Studio = day * 75.20;
                    price = day * 68.70;
                    break;
                case "August":
                case "July":
                    Studio = day * 76;
                    price = day * 77;
                    break;

            }

            if (day > 14 && (month == "May" || month == "October"))   // отстъпки 
            {
                Studio = Studio - Studio * 0.3;
            }
            else if (day > 14 && (month == "June" || month == "September"))
            {
                Studio = Studio - Studio * 0.2;
            }
            else if (day > 7 && (month == "May" || month == "October"))
            {
                Studio = Studio - Studio * 0.05;
            }

            if (day > 14)
            {
                price = price - price * 0.1;
            }

            Console.WriteLine($"Apartment: {price:f2} lv.");
            Console.WriteLine($"Studio: {Studio:f2} lv.");
        }
    }
}