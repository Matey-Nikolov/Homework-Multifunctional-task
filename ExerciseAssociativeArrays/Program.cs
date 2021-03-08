namespace ExerciseAssociativeArrays
{
    using System;
    using System.Collections.Generic;

    class Program
    {

        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> countingChar = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (countingChar.ContainsKey(input[i]) == false)
                    {
                        countingChar.Add(input[i], 0);
                    }
                    countingChar[input[i]]++;
                }
            }

            foreach (var kvp in countingChar)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
