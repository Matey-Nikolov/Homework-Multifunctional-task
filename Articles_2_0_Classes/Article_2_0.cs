using System;
using System.Collections.Generic;
using System.Text;

namespace Articles_2_0_Classes
{
    class Article_2_0
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
