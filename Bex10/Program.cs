namespace Bex10
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {

        }

        static List<double> GetdoubleNumbers(List<string> inupt)
        {
            double parseNumber = 0;
            List<double> result = new List<double>();
            for (int i = 0; i < input.Count; i++)
            {
                if (double.TryParse(inupt[i], out parseNumber))
                {
                     result.Add(parseNumber);
                }
            }
            return result;
        }

    }
}
