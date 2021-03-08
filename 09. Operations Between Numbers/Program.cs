using System;

namespace _09._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double num1 = double.Parse(Console.ReadLine());
            string nameon = Console.ReadLine();

            double num2 = 0;

            switch (nameon)
            {
                case "+":
                    num2 = num + num1;
                   
                    break;
                case "-":
                    num2 = num - num1;
                    break;
                case "*":
                    num2 = num * num1;
                    break;
                case "/":
                    num2 = num / num1;
                    break;
                case "%":
                    num2 = num % num1;
                    break;
            }

            if (num1 == 0)
            {
                Console.WriteLine($"Cannot divide {num} by zero");
            }
            else
            {
                if (nameon == "/")
                {
                    Console.WriteLine($"{num} / {num1} = {num2:f2}");
                }
                else if (nameon == "%")
                {
                    Console.WriteLine($"{num} % {num1} = {num2}");
                }
                else if (num2 % 2 == 0)
                {
                    Console.WriteLine($"{num} {nameon} {num1} = {num2} - even");
                }
                else
                {
                    Console.WriteLine($"{num} {nameon} {num1} = {num2} - odd");
                }

            }
        }
    }
}
