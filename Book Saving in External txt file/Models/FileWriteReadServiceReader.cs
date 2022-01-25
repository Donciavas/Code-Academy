using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSavingInExternalTxtFile.Models
{
    public class FileWriteReadServiceReader
    {
        //private readonly string _path = @"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\Sausio 25 d pamoka\Sausio 25 d pamoka\BorrowerDataBase.txt";
        private readonly string _path = @"C:\Users\dvitk\OneDrive\Documents\CodeAcademy\C#.net\Sausio 25 d pamoka\Sausio 25 d pamoka\BorrowerDataBase.txt";

        public void AppendText(string text)
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine(text);
            }
        }
        public void WriteAllText(string[] lines)
        {
            File.WriteAllLines(_path, lines);
        }

        public List<string> GetAllLines()
        {
            var lines = File.ReadAllLines(_path);
            return lines.ToList();
        }


    }
}