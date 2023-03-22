using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;

namespace web_scraper
{
    internal class Web_scraper
    {
        private static async Task<string> call_url(string fullUrl)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(fullUrl);
            return response;
        }
        private static List<string> parse_html(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            //XPath
            //var book_names = htmlDoc.DocumentNode.SelectNodes("//a[@class='pollAnswer__bookLink']");

            //LINQ
            var parsed_data = htmlDoc.DocumentNode.Descendants("a")
                .Where(node => node.GetAttributeValue("class", "").Contains("pollAnswer__bookLink")).
                ToList();

            List<string> book_data = new List<string>();
            foreach (HtmlNode book in parsed_data)
            {
                book_data.Add(book.FirstChild.GetAttributeValue("alt", ""));
            }

            return book_data;
        }
        public static List<string> get_books_data(string url)
        {
            string response = call_url(url).Result;
            List<string> book_data = parse_html(response);
            return book_data;
        }
    }
}