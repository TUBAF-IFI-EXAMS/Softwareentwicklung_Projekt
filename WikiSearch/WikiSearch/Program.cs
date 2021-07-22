using System;
using System.Windows.Forms;

namespace WikiSearch
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Suchoverlay());
        }
    }
}


/*using System;
using WikiDotNet;
//using System.Windows.Forms;

namespace WikipediaParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie hier Ihren Suchbegriff ein:");
            string searchString = Console.ReadLine();
            WikiSearchSettings searchSettings = new WikiSearchSettings
            { RequestId = "Request ID", ResultLimit = 5, ResultOffset = 2, Language = "en" };

            WikiSearchResponse response = WikiSearcher.Search(searchString, searchSettings);

            Console.WriteLine($"\nResults found ({searchString}):\n");
            foreach (WikiSearchResult result in response.Query.SearchResults)
            {
                Console.WriteLine(
                    $"\t{result.Title} ({result.WordCount} words, {result.Size} bytes, id {result.PageId}):\t{result.Preview}...\n\tAt {result.Url(searchSettings.Language)}\n\tLast edited at {result.LastEdited}\n");
            }
        }
    }
}
*/