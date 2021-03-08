using System;
using System.Collections.Generic;
using System.Linq;

namespace ex1._7
{
    class Program
    {
        static void Main()
        {

            string egn = Console.ReadLine();

            if (egn.Length != 10)
            {
                Console.WriteLine("Invalid EGN. Must be 10 digits");
                Console.WriteLine("Try again");
                egn = Console.ReadLine();
            }

            int sum = 0;
            int weight = 0;

            for (int i = 0; i < egn.Length - 1; i++)
            {
                int digits = int.Parse(egn[i].ToString());

                switch (i)
                {
                    case 0: weight = 2; break;
                    case 1: weight = 4; break;
                    case 2: weight = 8; break;
                    case 3: weight = 5; break;
                    case 4: weight = 10; break;
                    case 5: weight = 9; break;
                    case 6: weight = 7; break;
                    case 7: weight = 3; break;
                    case 8: weight = 6; break;
                }
                sum += digits * weight;
            }

            int controlDigit = sum % 11;
            controlDigit %= 10;

            if (controlDigit > 10)
            {
                controlDigit = 0;
            }

            if (controlDigit == int.Parse(egn[9].ToString()))
            {
                Console.WriteLine("EGN is valid: ");
                Console.Write(controlDigit);
            }
            else
            {
                Console.WriteLine("EGN is not valid:");
            }
        }
    }
}
