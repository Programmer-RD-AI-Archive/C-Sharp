// Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace important
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 =
                new Book("The C# Programming Language",
                    "Microsoft",
                    "Microsoft Press",
                    2000,
                    496,
                    "978-0-7356-6745-7");
            Console.WriteLine(Book.songCount);

            Console.ReadLine();
        }
    }

    class BadProgram : Program
    {
        static void Main(string[] args)
        {
            Book book1 =
                new Book("The C# Programming Language",
                    "Microsoft",
                    "Microsoft Press",
                    2000,
                    496,
                    "978-0-7356-6745-7");
            Console.WriteLine(Book.songCount);

            Console.ReadLine();
        }
    }
}
