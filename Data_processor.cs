using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    internal class Data_processor
    {
        public static List<string[]> process_data(List<string> data) 
        {
            List<string[]> processed_data = new List<string[]>();
            foreach (string item in data) 
            {
                processed_data.Add(item.Split("by"));
            }
            return processed_data;
        }
    }
}
