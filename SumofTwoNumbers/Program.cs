using System;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startoftheinterva = int.Parse(Console.ReadLine());
            int endoftheinterval = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int n = 0;
            int number2 = 0;
            for (int i = startoftheinterva; i <= endoftheinterval; i++)
            {
           
                for (int b = startoftheinterva; b <= endoftheinterval; b++)
                {
               
                    number2 = i + b;
                    n++;

                    if ((number2 == number) )
                    {
                        
                        Console.WriteLine($"Combination N:{n} ({i} + {b} = {number})");
                        return;
                    n}
                                       
                }
            }
               Console.WriteLine($"{n} combinations - neither equals {number}");
           
        }
    }
}
