namespace Mathoperations
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondnumber = int.Parse(Console.ReadLine());

            double sum = Calculate(number, @operator, secondnumber);
            Console.WriteLine(sum);
        }

        static double Calculate(int number, string @operator, int secondnumber)
        {
            double result = 0;

            switch (@operator)
            {
                case "/": result = number / secondnumber; break;
                case "*": result = number * secondnumber; break;
                case "+": result = number + secondnumber; break;
                case "-": result = number - secondnumber; break;
            }
            return result;
        }
    }
}