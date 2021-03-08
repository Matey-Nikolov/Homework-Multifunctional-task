using System;

namespace Транспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();

            double total = 0;

            if (n >= 20 || 99 <= n)
            {
                switch(d)
                {
                    case "day":
                    case "night":
                        total = n * 0.09;
                        break;
                }
            }
            else if (n < 20)
            {
                switch (d)
                {
                    case "day":
                        total = (n * 0.79) + 0.70;
                        break;
                    case "night":
                        total = (n * 0.90) + 0.70;
                        break;
                }
            }

            if (n >= 100)
            {
                switch (d)
                {
                    case "day":
                    case "night":
                        total = n * 0.06;
                        break;
                }
            }

            Console.WriteLine($"{total:f2}");
        }    
    }
}
