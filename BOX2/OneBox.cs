using System;
using System.Collections.Generic;
using System.Text;

namespace BOX2
{
    class OneBox
    {
        public OneBox()
        {
            this.Item = new Item();
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQauntity { get; set; }

        public decimal PriceOfBox
        {
            get
            {
                return ItemQauntity * Item.Price;
            }
        }

    }
}
