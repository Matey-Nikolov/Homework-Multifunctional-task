using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string week = Console.ReadLine();
            double sum = double.Parse(Console.ReadLine());

            double totalsum = 0;

            int a = 0;

            switch (fruit)
            {
                case "banana":
                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 2.50;
                            break;

                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 2.70;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "apple":
                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 1.20;
                            break;

                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 1.25;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "orange":
                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 0.85;
                            break;

                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 0.90;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":

                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 1.45;
                            break;
                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 1.60;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "kiwi":
                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 2.70;
                            break;

                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 3.00;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "pineapple":
                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 5.50;
                            break;

                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 5.60;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                case "grapes":
                    switch (week)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            totalsum = totalsum + sum * 3.85;
                            break;

                        case "Saturday":
                        case "Sunday":
                            totalsum = totalsum + sum * 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;

                default: 
                    Console.WriteLine("error");
                    a++;
                    break;
            }

            if(a == 0)
            Console.WriteLine($"{totalsum:f2}");
        }
    }
}
