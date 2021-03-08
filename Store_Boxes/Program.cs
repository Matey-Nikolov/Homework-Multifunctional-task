using System;
using System.Collections.Generic;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main()
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] serialNumberItemNameItemQuantityItemPrice = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = serialNumberItemNameItemQuantityItemPrice[0];

                if (serialNumber == "end")
                    break;

                string itemName = serialNumberItemNameItemQuantityItemPrice[1];
                int itemQuantity = int.Parse(serialNumberItemNameItemQuantityItemPrice[2]);
                decimal itemPrice = decimal.Parse(serialNumberItemNameItemQuantityItemPrice[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuantity,
                };


                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                boxes.Add(box);
            }

            List<Box> temp = boxes
               .OrderByDescending(x => x.PriceBox)
               .ToList();

            foreach (Box box1 in temp)
            {
                Console.WriteLine(box1.SerialNumber);
                Console.WriteLine($"-- {box1.Item.Name} - ${box1.Item.Price:f2}: {box1.ItemQuantity}");
                Console.WriteLine($"-- ${box1.PriceBox:f2}");
            }

        }
    }
}