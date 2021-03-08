using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class CountBracket
    {
        public string CountBrackets()
        {
            // 3
            //
            Console.Write("Enter a task with parentheses: ");
            string task = Console.ReadLine().ToLower();

            int counter = 0;
            int taskLength = task.Length;

            for (int i = 0; i < taskLength; i++)
            {
                if (task[i] == '(')
                    counter++;
                else if (task[i] == ')')
                    counter--;
            }

            if (counter == 0)
                return "Properly placed brackets.";

            return "Improperly placed brackets";
        }

    }
}