using System;

namespace Honey_Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowertype = Console.ReadLine();
            double numberflowers = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double honey = 0.0;

            switch (flowertype) // Проверяваме типа цвете. В съотведствие с името на цветето влизаме в друг switch.
            {
                case "Sunflower":
                    switch (season)  // 
                    {
                        case "Spring": honey = numberflowers * 10; break;   //
                        case "Summer": honey = numberflowers * 8; break;   // Какъвто е сезона такова ще е производството.
                        case "Autumn": honey = numberflowers * 12; break; //
                    }
                    break;
                case "Daisy":
                    switch (season)
                    {
                        case "Spring": honey = numberflowers * 12; break;    //
                        case "Summer": honey = numberflowers * 8; break;    // Какъвто е сезона такова ще е производството за Daisy.
                        case "Autumn": honey = numberflowers * 6; break;   //
                    }
                    break;
                case "Lavender":
                    switch (season)
                    {
                        case "Spring": honey = numberflowers * 12; break;  //
                        case "Summer": honey = numberflowers * 8; break;  // Повтаря се процеса.
                        case "Autumn": honey = numberflowers * 6; break; //
                    }
                    break;
                case "Mint":
                    switch (season)
                    {
                        case "Spring": honey = numberflowers * 10; break;
                        case "Summer": honey = numberflowers * 12; break;
                        case "Autumn": honey = numberflowers * 6; break;
                    }
                    break;
            }

            // Правя си if else, за да видя дали ще са произведели повече количество мед или по - малко.

            if (season == "Spring" && (flowertype == "Daisy" || flowertype == "Mint"))
            {
                honey = honey + honey * 0.1;  // Пресмятаме процента увеличение.
            }
            else if (season == "Summer")
            {
                honey = honey + honey * 0.1; // Пресмятаме процента увеличение.
            }
            else if (season == "Autumn")
            {
                honey = honey * 0.95; // Пресмятаме процента увеличение.
            }

            Console.WriteLine($"Total honey harvested: {honey:f2}"); // Отпечатваме колко мед е произведено.
        }
    }
}
