// Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace important
{
    class Book
    {
        public string Title;

        public string Author;

        public string Publisher;

        public static int songCount = 0;

        public int year
        {
            get
            {
                return year;
            }
            set
            {
                if (value == 2000)
                {
                    year = value;
                    Console.WriteLine (year);
                }
                else
                {
                    Console.WriteLine("Invalid year");
                }
            }
        }

        public int Pages;

        public string Isbn;

        public Book(
            string aTitle,
            string aAuthor,
            string aPublisher,
            int aYear,
            int aPages,
            string aIsbn
        )
        {
            Title = aTitle;
            Author = aAuthor;
            Publisher = aPublisher;
            year = aYear;
            Pages = aPages;
            Isbn = aIsbn;
            songCount++;
        }

        public string cool_out_string_lol()
        {
            return "cool";
        }
    }
}
