using System;

namespace Honey_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amounthoney = double.Parse(Console.ReadLine());      //  Инициализирам количеството мед необходимо за зимата.
            string namebee = "";                                       //  

            double collected = 0;                                      // Събралото количество мед от пчелата.
            double enough = 0;                                        // Дали е стигнало това количество.
            int a = 0;                                               // Една проверка.
            namebee = Console.ReadLine();                           // Инициализирам името на пчелата.

            while (namebee != "Winter has come")            // while служи за вход.
            {

                    double beehoney = double.Parse(Console.ReadLine());

                    collected = collected + beehoney;                       // Тук събирам предходния месец със следващия.

                for ()
                if (collected >= amounthoney)                           // Излезаме от for-а и провеляваме дали пчелата е събрала меда, от който се нуждаем.
                {
                    a++;                            // Това "а" се инкрементира с единица. По надолу ще ни трябва.
                    enough = collected - amounthoney;
                    Console.WriteLine($"Well done! Honey surplus {enough:f2}.");     // Изписва се излишния мед.
                    break;                                                          // излизаме от while.
                }
                else if (collected < 0)                                     // Ако събрания мед е по-малко от 0, тоест пчелата е изяла меда, я гоним.
                {
                    Console.WriteLine($"{namebee} was banished for gluttony");
                }
                namebee = Console.ReadLine();                               // Въвеждаме нова пчела.
            }

            if (a != 1)                                            // Ако не сме събрали меда след въвеждане на "Winter has come" и  a != 1, влизаме.
            {
                enough = amounthoney - collected;                                   // Смятаме дали от нужното количество ни стига меда.
                if (enough > amounthoney)                                          // Проверявам дали достатъчното е повече от нужното.
                {
                    Console.WriteLine($"Well done! Honey surplus {amounthoney}.");      // Отпечатва се когато ни стига.
                }
                else                                                  // Ако не е да се изпечатва, че не ни достига и с колко.
                {
                    Console.WriteLine($"Hard Winter! Honey needed {enough:f2}.");
                }

            }
        }
    }
}
