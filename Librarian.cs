using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    internal class Librarian : ILibraryManagement
    {
        Library managed_library;
        public Librarian()
        {
            managed_library = new Library();
        }
        public void update_library_inventary(string url)
        {
            Console.WriteLine("Cargando contenido desde Goodreads...");
            managed_library.load_data(url);
            Console.WriteLine("Contenido cargado...");
        }
        public bool is_book_avaialable_by_name(string book_name)
        {
            Console.WriteLine("Buscando en inventario...");
            return managed_library.is_book_avaialable_by_name(book_name);
        }
        public void print_inventary_list()
        {
            foreach(Book book in this.managed_library.get_inventary())
            {
                Console.WriteLine(book);
            }
        }
    }
}
