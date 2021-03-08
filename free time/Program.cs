using System;

namespace free_time
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayfree = Console.ReadLine();
            int hour = int.Parse(Console.ReadLine());

            if (hour >= 10 && hour <= 22)
            {
                //  Console.WriteLine($"You cannot disturb Maria on {dayfree} at {hour}.");

                int n = int.Parse(Console.ReadLine());
                
                if (n >= 3 && n <= 7)
                {
                    for (int i = 0; i < n; i++)
                    {
                        string ndays = Console.ReadLine();
                        
                        if (ndays == dayfree)
                        {
                            Console.WriteLine($"Maria is free on {dayfree} at {hour}.");
                        }
                    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  


                }
                else
                {
                    Console.WriteLine($"{n} is invalid number.");
                }

            }
            else
            {
                Console.WriteLine($"You cannot disturb Maria on {dayfree} at {hour}.");
                return;
            }
            


        }
    }
}
