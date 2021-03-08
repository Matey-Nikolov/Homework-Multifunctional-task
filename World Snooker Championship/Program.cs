using System;

namespace World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stageofthechampionship = Console.ReadLine();
            string typeofticket = Console.ReadLine();
            double numberoftickets = double.Parse(Console.ReadLine());
            string photowiththetrophy = Console.ReadLine();


            double totalsum = 0.0;
            int i = 0;

            switch (stageofthechampionship)
            {
                case "Quarter final":
                    switch (typeofticket)
                    {
                        case "Standard": totalsum = numberoftickets * 55.50; break;
                        case "Premium": totalsum = numberoftickets * 105.20; break;
                        case "VIP": totalsum = numberoftickets * 118.90; break;
                    }
                    break;
                case "Semi final":
                    switch (typeofticket)
                    {
                        case "Standard": totalsum = numberoftickets * 75.88; break;
                        case "Premium": totalsum = numberoftickets * 125.22; break;
                        case "VIP": totalsum = numberoftickets * 300.40; break;
                    }
                    break;
                case "Final":
                    switch (typeofticket)
                    {
                        case "Standard": totalsum = numberoftickets * 110.10; break;
                        case "Premium": totalsum = numberoftickets * 160.66; break;
                        case "VIP": totalsum = numberoftickets * 400.0; break;
                    }
                    break;
            }

            if (totalsum > 4000)
            {
                totalsum = totalsum * 0.75; // 
            }
            else if (totalsum <= 4000 && totalsum > 2500)
            {
                totalsum = totalsum * 0.90;//
                                           //
            }


            if (photowiththetrophy == "Y" && totalsum <= 4000)
            {
                totalsum = totalsum + numberoftickets * 40.0;
            }


            Console.WriteLine($"{totalsum:f2}");
        }
    }
}
