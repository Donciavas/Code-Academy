using System;
using System.Collections.Generic;

namespace Sausio_18_d_pamoka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sausio 18 d pamoka\r\n");

            #region TEORIJA – XUnits

            //
            //
            //

            #endregion

            //Problem1();
            Problem2();

        }

        public static void Problem1()
        {
            // Sukurti struktūrą mokynis. Laukai: List<int> trimestras1, <int> trimestras2,
            // <int> trimestras 3. Metodai: public int PirmoTrimestroVidurkis(),
            // public int AntroTrimestroVidurkis(), public int trečioTrimestroVidurkis(),
            // public int MetinisPažimys() + unit testai;

            var Trimester1 = new List<double> { 10, 8, 10 };
            var Trimester2 = new List<double> { 9, 9, 6 };
            var Trimester3 = new List<double> { 5, 5, 8 };

            var allGrades = new Problem1Struct(Trimester1, Trimester2, Trimester3);
            allGrades.PrintValues();

        }

        public static void Problem2()
        {
            // Sukurti struktūrą Sąskaita.Laukai: SaskNr ir Viso.Sukurti struktūrą
            // Buhalterija.Laukai List<saskaita>.Pridėti metodus bendrai visų sąskaitų
            // sumai suskaičiuoti. Ekrane parodyti viso sąskaitų xxx, Viso Suma: yyy

            var sf1 = new Problem2Struct("101", 100f);
            var sf2 = new Problem2Struct("102", 200f);
            var sf3 = new Problem2Struct("103", 300f);
            var sf4 = new Problem2Struct("104", 400f);
            var sf5 = new Problem2Struct("105", 500f);

            var Finances = new Finances(new List<Problem2Struct>());

            Finances.AddToFinanceList(sf1);
            Finances.AddToFinanceList(sf2);
            Finances.AddToFinanceList(sf3);
            Finances.AddToFinanceList(sf4);
            Finances.AddToFinanceList(sf5);

            Finances.PrintValues();


        }

        public static void Problem3()
        {
            //Modifikuoti programą sukurtą 2-je užduotyje: sukurti meniu su galimybe
            //pridėti trinti bet kurio trimestro pažymius, matyti trimesto vidurkius
            //ir galutinį metinį pažymį
        }






    }
}