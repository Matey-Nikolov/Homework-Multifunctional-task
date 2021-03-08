using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();


            int prime = 0;
            int nonprime = 0;


            while (number != "stop")
            {
                int number2 = int.Parse(number);

                if (number2 < 0)
                {
                    Console.WriteLine("Number is negative.");
                    number2 = 0;
                }
                else
                {


                    for (int a = 2; a <= number2; a++)
                    {
                        if (number2 % a == 0)
                        {
                            prime += number2;
                            break;
                        }
                        else
                        {
                            nonprime += number2;
                        }
                    }
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprime}");

        }
    }
}
