using Sausio_20_d_paskaita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs14_paskaita_Class");

            // 1. Book entity
            // 2. Books repository
            // 3. Repository saves a book in a file

            var Book1 = new Book("LotR", "OldManNtheSea", "Harry Potter");

        BookSavingFunction(Book1);

            System.IO.File.AppendText("Book_DB.txt").WriteLine("Your texxt");
        }


    }

