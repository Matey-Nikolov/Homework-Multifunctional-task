using System;

namespace Lamp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int state = 0;
                string command = Console.ReadLine();

              //  if (command == "off")
             //   {
               //      return;
               // }

                if (state == 0)
                {
                    if (command == "on")
                    {
                        state = 1;
                    }
                    else if (command == "off")
                    {
                        state = 0;
                    }
                }
                else if (state == 1)
                {
                    if (command == "on")
                    {
                        state = 1;
                    }
                    else if (command == "off")
                    {
                        state = 0;
                    }
                }

                if (state == 1)
                {
                    Console.WriteLine("Lamp is on");
                }
                else if (state == 0)
                {
                    Console.WriteLine("Lamp is off");
                }
            }
        }
    }
}
