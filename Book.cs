using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    internal class Book
    {
        public string name;
        public string author;
        public Book(string Name, string Author) { name = Name; author = Author; }

        public override string ToString()
        {
            return $"{name} by {author}";
        }
    }
}
