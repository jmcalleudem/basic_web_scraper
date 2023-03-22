using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Librarian librarian = new Librarian();
            librarian.update_library_inventary("https://www.goodreads.com/choiceawards/best-science-fiction-books-2022");
            librarian.print_inventary_list();
            Console.WriteLine(librarian.is_book_avaialable_by_name("sea of tranquility"));
        }
    }
}
