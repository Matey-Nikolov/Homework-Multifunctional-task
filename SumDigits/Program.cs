
namespace SumDigits
{
    using System;

    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            PrintSumDigits(number);
        }

        static void PrintSumDigits(string number)
        {
            int sum = 0;
          //  foreach (char currentDigits in number)
          //  {
         //       sum += int.Parse(currentDigits.ToString());
          //  }

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
