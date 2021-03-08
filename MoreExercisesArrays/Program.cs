namespace MoreExercisesArrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];
            int[] encrypted = new int[n];



            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i < n;i++)
            {

                string currentElement = array[i];
                int vowels = 0;
                int consonants = 0;

                for (int a = 0; a < currentElement.Length; a++)
                {
                    if ("aeiouAEIOU".IndexOf(currentElement[a].ToString()) >= 0) // currentElement[j] == 'a' || ...
                    {
                        vowels += currentElement[a] * currentElement.Length;
                    }
                    else
                    {
                        consonants += currentElement[a] / currentElement.Length;
                    }
                }
                encrypted[i] = vowels + consonants;
            }

            Array.Sort(encrypted);
            Console.WriteLine(string.Join(("\n"), encrypted));

        }
    }
}
