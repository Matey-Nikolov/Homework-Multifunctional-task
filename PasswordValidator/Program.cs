
namespace PasswordValidator
{
    using System;


    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine().ToLower();

            if (!PswLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!PswLetterDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!PswDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }


            if (PswLength(password) && PswLetterDigits(password) && PswDigits(password))
            Console.WriteLine("Password is valid");

            static Boolean PswLength(string password)
            {
                if (password.Length >= 6 && password.Length <= 10)
                    return true;
                else
                    return false;
            }

            static Boolean PswLetterDigits(string password)
            {
                int num = 0;
                int let = 0;

                for (int i = 0; i < password.Length; i++)
                {

                    if ('0' <= password[i] && password[i] <= '9')
                        num++;
                    if ('a' <= password[i] && password[i] <= 'z')
                        let++;
                }
                                if (num + let == password.Length) return true;
                else return false;

            }

            static Boolean PswDigits(string password)
            {
                int num = 0;

                for (int i = 0; i < password.Length; i++)
                {
                    if ('0' <= password[i] && password[i] <= '9')
                        num++;
                }

                if (num >= 2) return true;
                else return false;
            }
        }
    }
}

