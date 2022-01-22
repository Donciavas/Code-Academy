using System;

namespace Sausio_20_d_paskaita
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            var bookName = System.IO.File.AppendText(@"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\Sausio 20 d paskaita\BookList.txt");
            bookName.Flush();
            bookName.WriteLine("LotR");
            bookName.WriteLine("HP");
            bookName.WriteLine("OldManAndTheSea");
            bookName.Close();
        }
    }
}
