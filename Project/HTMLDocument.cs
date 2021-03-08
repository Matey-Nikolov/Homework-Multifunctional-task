using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Project
{
    class HTMLDocument
    {
        public string Document()
        {
            // 16
            //

            string text = Console.ReadLine();

            string cap = " ";

            int openTag = text.IndexOf("<a href=");
            int closeTag = text.IndexOf("</a>");

            while (openTag != -1 && closeTag != -1)
            {
                cap = text.Substring(openTag + "<a href=".Length, closeTag - openTag - +"</a>".Length);
                text = text.Remove(openTag, closeTag + "</upcase>".Length - openTag);

                text = text.Insert(openTag, "[URL =");



                openTag = text.IndexOf("<a href=", closeTag - "<a href=".Length);
                closeTag = text.IndexOf("</a>", closeTag - "</a>".Length - "<a href=".Length);
            }
            return text;
        }

        public string DocumentRegex()
        {
            Console.WriteLine("Enter a doc example <a href=\"https://softuni.bg\">our site</a>");
            string doc = Console.ReadLine();
            /*
            string doc = "<p>Please visit <a href=\"https://softuni.bg\">our site</a> " +
                         "to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> " +
                         "to discuss the courses.</p>";
            */
            doc = Regex.Replace(doc, "<a href=\"", "[URL=");
            doc = Regex.Replace(doc, "\">", "]");
            doc = Regex.Replace(doc, "</a>", "[/URL]");

           return doc;
        }
    }
}