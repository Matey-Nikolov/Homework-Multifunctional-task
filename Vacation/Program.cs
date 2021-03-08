using System;


namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyneededfortheexcursion = double.Parse(Console.ReadLine());
            double moneyonhand = double.Parse(Console.ReadLine());

            int counterspend = 0;
            int counterdays = 0;

            while (counterspend < 5)
            {

                if (moneyonhand >= moneyneededfortheexcursion)
                {
                    Console.WriteLine($"You saved the money for {counterdays} days.");
                    break;
                }

                string spendorSave = Console.ReadLine();
                double moneyseveorspend = double.Parse(Console.ReadLine());

                switch (spendorSave)
                {
                    case "spend":
                        moneyonhand = moneyonhand - moneyseveorspend;
                        counterspend++;

                        if (moneyonhand < 0)
                            moneyonhand = 0;

                        break;
                    case "save":

                        moneyonhand = moneyonhand + moneyseveorspend;
                        counterspend = 0;

                        break;
                }

                counterdays++;
              
                if (moneyonhand >= moneyneededfortheexcursion)
                {
                    Console.WriteLine($"You saved the money for {counterdays} days.");
                    break;
                }
                
                if (counterspend >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(counterdays);
                    break;
                }
            }
        }
    }
}
