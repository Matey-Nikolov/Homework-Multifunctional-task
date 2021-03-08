namespace ExerciseMethods
{
    using System;

    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            PrintSmallNumber(number1, number2, number3);

        }

        static void PrintSmallNumber(int number1, int number2, int number3)
        {
            if ((number1 <= number2) && (number1 <= number3))
                Console.WriteLine(number1);
            else if ((number2 <= number1) && (number2 <= number3))
                Console.WriteLine(number2); 
            else
                Console.WriteLine(number3);
        }
    }
}
