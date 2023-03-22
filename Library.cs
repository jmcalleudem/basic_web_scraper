using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    internal class Library: ILibraryManagement
    {
        List<Book> inventary = new List<Book>();

        public void load_data(string url)
        {
            List<string> scraped_data = Web_scraper.get_books_data(url);
            List<string[]> processed_data = Data_processor.process_data(scraped_data);
            foreach (string[] data in processed_data)
            {
                inventary.Add(new Book(data[0], data[1]));
            }
        }

        public bool is_book_avaialable_by_name(string book_name)
        {
            var response = inventary.Find(book => book.name.ToLower().Contains(book_name.ToLower()));
            return response != null;
        }
        public List<Book> get_inventary()
        {
            return inventary;
        }
    }
}
