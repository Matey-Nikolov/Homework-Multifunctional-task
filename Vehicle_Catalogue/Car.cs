using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Catalogue
{
    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Model} - {this.HorsePower}hp";
        }
    }
}
