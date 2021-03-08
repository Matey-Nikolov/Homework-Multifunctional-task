﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Catalogue
{
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }
}
