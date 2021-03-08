namespace RoundingNumbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine() // 0.1 0.5 2.4
                .Split(" ")                      // [0.1][0.5][2.4]
                .Select(x => double.Parse(x))   //
                .ToArray();

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine($"{(decimal)numbers[index]} => {(decimal)Math.Round(numbers[index], MidpointRounding.AwayFromZero)}");
            }

            // Select (x => x + "asd") a ---> a+asd = aasd 
            //          otiva          b ---> b+asd = basd
            //  
        }
    }
}
