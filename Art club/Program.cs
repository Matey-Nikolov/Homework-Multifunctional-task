using System;

namespace Art_club
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstrow = int.Parse(Console.ReadLine()); // Инилициаризираме посетителите.
           // string theactivityinaclub = Console.ReadLine(); // Задаваме на за всеки един човек длъжност.

            int paint = 0;      // Въвеждам си нови проминливи.
            int knit = 0;      //  Колко човека са на тази
            int sing = 0;     //    длъжност.
            int dance = 0;   //

            int souvenir = 0;  // Колко от тях, колко са си купили нещо.
            int tea = 0;      // 

            double creatingart = 0;   // Процент от хората с арт активност.
            double buyingaproduct = 0; // Процент от хората са си взели нещо.

            for (int i = 0; i < firstrow; i ++)                   // Правя си  for цикъл - обхожда всички посетители(редове).
            {
                string theactivityinaclub = Console.ReadLine();   // Задаваме на всеки един човек длъжност.
                
                switch (theactivityinaclub)  // Обхождаме длъжността.
                {
                    case "Paint": paint++; break;        //
                    case "Knit": knit++; break;         //  Събираме хората.
                    case "Sing": sing++; break;        //
                    case "Dance": dance++; break;     //

                    case "Souvenir": souvenir++; break;  //  Събираме хората закупили нещо.
                    case "Tea": tea++; break;           //   

                }

                buyingaproduct = (souvenir + tea) * 100.0 / firstrow;              //  Смятаме процентите.
                creatingart = (paint + knit + sing + dance) * 100.0 / firstrow;   // 
            }


            // Нещата, които трябват да се изведат  от конзолата.
            Console.WriteLine($"{paint} - Paint");
            Console.WriteLine($"{knit} - Knit");
            Console.WriteLine($"{sing} - Sing");
            Console.WriteLine($"{dance} - Dance");
            Console.WriteLine($"{souvenir} - Souvenir");
            Console.WriteLine($"{tea} - Tea");
            Console.WriteLine($"{creatingart:f2}% - creating art");
            Console.WriteLine($"{buyingaproduct:f2}% - buying a product");
        }
    }
}