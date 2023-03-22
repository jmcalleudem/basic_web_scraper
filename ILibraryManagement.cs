using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    internal interface ILibraryManagement
    {
        public Boolean is_book_avaialable_by_name(string book_name);
    }                                                 
}
