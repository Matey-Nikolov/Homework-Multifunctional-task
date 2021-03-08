using System;

namespace Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double homenumber = double.Parse(Console.ReadLine());
            double endnumber  = double.Parse(Console.ReadLine());

          

            for (double a = homenumber; a <= endnumber; a++)
            {
               
                for (double b = homenumber; b <= endnumber; b++)
                {
                    
                    for (double c = homenumber; c <= endnumber; c++)
                    {

                        for (double d = homenumber; d <= endnumber; d++)
                        {
                            if ((a % 2 == 0 && d % 2 != 0) && (a > d && (b + c) % 2 == 0) )
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                            else if ((a % 2 != 0 && d % 2 == 0 ) && (a > d && (b + c) % 2 == 0))
                            {

                                Console.Write($"{a}{b}{c}{d} ");
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                }
            }
        }
    }
}
