using System;

namespace FruitorVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitorvegetable = Console.ReadLine();

            switch (fruitorvegetable)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
