using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexUsed
{
    class BookOfQuotes
    {
        private string[] quotes = new string[100];

        // making an indexer
        public string this[int index]
        {
            get {
                return quotes[index];
            }

            set {
                 quotes[index] = value;
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            BookOfQuotes book = new BookOfQuotes();
            book[0] = "Yipee KAYAI NUTHA FUCKAS!!!!";

            Console.WriteLine(book[0]);
            Console.Read();
        }
    }
}
