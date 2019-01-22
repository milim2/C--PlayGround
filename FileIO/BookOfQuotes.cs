using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookOfQuotes
{

    class BookOfQuotes
    {
        private string[] quotes = new string[100];

        public string getQuote(int position)
        {
            return quotes[position];
        }

        public void setQuote(int position, string quote)
        {
            quotes[position] = quote;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            BookOfQuotes book = new BookOfQuotes();
            book.setQuote(0, "Make my day");
            book.setQuote(1, "You shall not pass");

            Console.WriteLine(book.getQuote(0));
            Console.WriteLine(book.getQuote(1));
            Console.Read();
        }
    }
}
