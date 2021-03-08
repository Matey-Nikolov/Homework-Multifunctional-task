namespace _15._12._2020
{
    using System;
    class Program
    {
        static void Main()
        {
            string name = "aaaAa";

            Console.WriteLine($"Space count: {SpaceCount(name)}");


        }

        static int SpaceCount(string str)
        {
            int spaceCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToLower(str[i]) == 'a') //str[i] == 'a' || str[i] == 'A'
                {
                    spaceCount++;
                }
            }
           
            return spaceCount;
        }
    }
}
