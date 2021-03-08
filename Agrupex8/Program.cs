namespace Agrupex8
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {

        }

        static List<double> GetNegativeNumbers(double[] numbers)
        {
            List<double> negativeNumbers = new List<double>();
            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeNumbers.Add(numbers[i]);
                }
            }
            return negativeNumbers;
            */
             return numbers.Where(el => el < 0).ToList();
        }
    }
}
