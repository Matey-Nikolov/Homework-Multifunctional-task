using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Objects_and_Classes
{
    class Dice
    {
        public Dice()
        {
            this.Sides = 6;  
        }

        public Dice(int sides)
        {
            this.Sides = sides;
        }


        public int Sides { get; set; }
        
        public string Type { get; set; }

        public  int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, Sides + 1);
        }

    }
}
