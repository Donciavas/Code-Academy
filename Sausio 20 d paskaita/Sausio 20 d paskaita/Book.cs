using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_20_d_paskaita
{
    public class Book
    {
        // 1. Book entity
        // 2. Books repository
        // 3. Repository saves a book in a file

        public string BookName;
        public string Author;
        public string BookRealeaseDate;

        public Book(string bookName, string author, string bookRealeaseDate)
        {
            BookName = bookName;
            Author = author;
            BookRealeaseDate = bookRealeaseDate;
        }
    }
}