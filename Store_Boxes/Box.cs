using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Boxes
{
    class Box
    {
        public Box()
        {
            Item = new Item();
        }


        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceBox
        {
            get
            {
                return ItemQuantity * Item.Price;
            }
        }
    }
}
