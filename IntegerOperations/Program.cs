
namespace IntegerOperations
{
    using System;

    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int thirdDivide = int.Parse(Console.ReadLine());
            int fourthMultiply = int.Parse(Console.ReadLine());

            int add = AddFirstandSecondNumbers(first, second);
            int divide = ThirdDivide(add, thirdDivide);
            int multiply = TourthMultiply(divide, fourthMultiply);

            Console.WriteLine(multiply);
        }

        private static int TourthMultiply(int divide, int fourthMultiply)
        {
            int sum = 0;
            return sum = divide * fourthMultiply;
        }

        static int ThirdDivide(int add, int thirdDivide)
        {
            int sum = 0;
            return sum = add / thirdDivide;
        }

        static int AddFirstandSecondNumbers(int first, int second)
        {
            int sum = 0;
            return sum = first + second;
        }
    }
}
