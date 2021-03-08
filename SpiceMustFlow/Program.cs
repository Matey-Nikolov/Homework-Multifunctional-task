namespace SpiceMustFlow
{
    using System;

    class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());

            int countDays = 0;
            int totalAmount = 0;


            if (startingYield < 100)
            {

                Console.WriteLine(countDays);
                Console.WriteLine(totalAmount);
            }
            else
            {

                while (startingYield >= 100)
                {
                    totalAmount = totalAmount + (startingYield - 26);

                    startingYield = startingYield - 10;
                    countDays++;

                    //            Console.WriteLine(countDays);
                    //            Console.WriteLine(totalAmount);
                    //            Console.WriteLine(startingYield);

                }

                if (countDays > 0)
                {
                    Console.WriteLine(countDays);

                    if (totalAmount >= 26)
                        totalAmount = totalAmount - 26;

                    Console.WriteLine(totalAmount);
                }
            }
        }
    }
}
