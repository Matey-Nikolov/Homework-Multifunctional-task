namespace Snowballs
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int snowballs = int.Parse(Console.ReadLine());

            int currentSnowballSnow = 0;
            int currentSnowballTime = 0;
            int currentSnowballQuality = 0;

            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;

            BigInteger currentHighest = 0;
            BigInteger Highest = 0;

            for (int i = 0; i < snowballs; i++)
            {
                currentSnowballSnow = int.Parse(Console.ReadLine());
                currentSnowballTime = int.Parse(Console.ReadLine());
                currentSnowballQuality = int.Parse(Console.ReadLine());

                currentHighest = ReturnHighestSnowballValue(currentSnowballSnow, currentSnowballTime, currentSnowballQuality);
             
                if (currentHighest > Highest)
                {
                    Highest = currentHighest;
                    snowballSnow = currentSnowballSnow;
                    snowballTime = currentSnowballTime;
                    snowballQuality = currentSnowballQuality;
                }
            }         
                Console.WriteLine($"{snowballSnow} : {snowballTime} = {Highest} ({snowballQuality})");
        }

        static BigInteger ReturnHighestSnowballValue(int snowballSnow, int snowballTime, int snowballQuality)
        {
            return BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
        }
    }
}
