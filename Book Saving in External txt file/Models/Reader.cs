using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_25_d_pamoka.Models
{
    public class Reader : Book
    {
        public string ReaderName { get; set; }

        public Reader()
        {

        }

        public Reader(string name, string author, int year, int bookAmount, string readerName) : base(name, author, year, bookAmount)
        {
            ReaderName = readerName;
        }


    }
}