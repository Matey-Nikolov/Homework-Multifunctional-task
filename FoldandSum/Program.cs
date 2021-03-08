namespace FoldandSum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int halfLength = array.Length / 4;
            int[] leftAndRigthElements = new int[halfLength];
            int[] middleElements = new int[halfLength];

            int curentIndext = 0;
            int lastIndext = array.Length - 1;

            for (int i = halfLength - 1; i >= 0; i--)
            {
                leftAndRigthElements[curentIndext] = array[i];
                middleElements[curentIndext] = array[halfLength / 2 + curentIndext];

                int index = curentIndext + halfLength / 2;

                leftAndRigthElements[index] = array[lastIndext - curentIndext];
                middleElements[curentIndext + halfLength /2] = array[halfLength + curentIndext];
                curentIndext++;
            }

            int[] result = new int[middleElements.Length];
            for (int i = 0; i < halfLength; i++)
            {
                 int cureentSum = leftAndRigthElements[i] + middleElements[i];
                result[i] = cureentSum;
            }

            Console.WriteLine(string.Join(" ", result));
            
        } 
    }
}