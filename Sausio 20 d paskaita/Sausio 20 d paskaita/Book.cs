using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_20_d_paskaita
{
    public class Book
    {
        public string BookName;

        public Book(string bookName)
        {
            BookName = bookName;
        }
    }
    public class BookRepository
    {
        public List<Book> BookList;

        public BookRepository(List<Book> booklist)
        {
            BookList = bookList;
        }
    
    }
}
