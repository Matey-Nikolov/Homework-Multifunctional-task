namespace Poke_Mon
{
    using System;

    class Program
    {
        static void Main()
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int pokeTargetsM = int.Parse(Console.ReadLine());
            byte exhaustionFactorY = byte.Parse(Console.ReadLine());

            int countTargets = 0;
            int remainedN = 0;

            double half = pokePowerN * 0.5;

            while (pokePowerN >= pokeTargetsM)
            {

                int subtracting = pokePowerN - pokeTargetsM;
                // double originalValueDivide = 0;
                int originalValue = 0;

                if (subtracting == half)
                {
                    if (subtracting / exhaustionFactorY == 0)
                    {
                        pokePowerN = (int)(subtracting / exhaustionFactorY);
                    }
            //        pokePowerN = originalValue;
                }
                else
                {
                    pokePowerN = subtracting;
                }
                countTargets++;
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(countTargets);
        }
    }
}
