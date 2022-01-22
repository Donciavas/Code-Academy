using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_20_d_paskaita
{
    // 1. Books repository
    // 2. Repository saves a book in a file
    public class BookRepository
    {
        public List<Book> BookList;

        public BookRepository(List<Book> bookList)
        {
            BookList = bookList;
        }

        public void BookSavingFunction(Book BookInstance)
        {
            BookList.Add(BookInstance);
        }
    }
}