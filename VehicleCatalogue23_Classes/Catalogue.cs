using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue23_Classes
{
    class Catalogue
    {
        public Catalogue()
        {
            this.Trucks = new List<Truck2>();
            this.Cars = new List<Car2>();
        }

        public List<Truck2> Trucks { get; set; }

        public List<Car2> Cars { get; set; }
    }
}
