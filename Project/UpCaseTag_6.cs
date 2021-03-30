using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Project
{
    class UpCaseTag_6
    {
        
        public string UpText()
        {
            
            // 6
            //"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."
            Console.WriteLine("Write a text with '<upcase>yellow submarine</upcase>': ");
            string text = Console.ReadLine();
            
            string cap = " ";
            
            int openTag = text.IndexOf("<upcase>");
            int closeTag = text.IndexOf("</upcase>");

            while (openTag != -1 && closeTag != -1)
            {
                cap = text.Substring(openTag + "<upcase>".Length, closeTag - openTag - +"<upcase>".Length);
                text = text.Remove(openTag, closeTag + "</upcase>".Length - openTag);
                text = text.Insert(openTag, cap.ToUpper());

                openTag = text.IndexOf("<upcase>", closeTag - "<upcase>".Length);
                closeTag = text.IndexOf("</upcase>", closeTag - "</upcase>".Length - "<upcase>".Length);
            }
            return text;
        }
        
    }
}
