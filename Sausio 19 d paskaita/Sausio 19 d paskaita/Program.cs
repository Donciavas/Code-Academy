using Models;
using System;

namespace Sausio_19_d_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sausio 19 d paskaita (12 paskaita)\r\n");
            #region TEORIJA – OOP - BIBLIOTEKOS

            //
            // OOP Bibliotekos
            // Inkapsuliacija -  duomenų paslėpimas; mechanizmai
            // leidžiantys uždrausti tiesioginį priėjimą prie objekto komponentų
            // Konstukcijos leidžiančios apjungti metodus ir struktūras;
            //
            // Paveldėjimas -
            // 
            //
            //
            // Polimorfizmas -
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //

            #endregion

            Problem1();

        }

        public static void Problem1()
        {
            var invoice1 = new Invoice("Sender", 200.0m);
            var invoice2 = new Invoice("Sender", 200.0m);
            var invoice3 = new Invoice("Sender", 200.0m);
            var invoice4 = new Invoice("Sender", 200.0m);
            var invoice5 = new Invoice("Sender", 200.0m);
            var invoice6 = new Invoice("Sender", 200.0m);
            var invoice7 = new Invoice("Sender", 200.0m);
        }

        public static void Problem2()
        {
            // Sukurti struktūrą Palmė. Public laukai: amžius ir vaisiųKiekis.
            // Abu tik skaitymui. Sukurti Public Metodą pridėti1MenAmziaus().
            // Palmė duoda vaisius nuo 5 iki 12 mėnesio, paskui miršta,
            // t. y. amžius tampa 0. Vaisiu kiekis = amžius*3

            var Palm1 = new PalmTree(2, 0);
            var Palm2 = new PalmTree(4, 0);
            var Palm3 = new PalmTree(8, 0);
            var Palm4 = new PalmTree(9, 0);
            var Palm5 = new PalmTree(15, 0);

            Palm1.PrintValues();
            Palm2.PrintValues();
            Palm3.PrintValues();
            Palm4.PrintValues();
            Palm5.PrintValues();
        }

        public static void Problem3()
        {
            // Sukurti struktūrą Point, public laukai x ir y tik skaitymui, perduodami
            // per konstruktorių. Sukurti struktūrą Rectangle, su public laukais:
            // TopLeft, BottomRight Point tipo.
            // Sukurti metodą bool isPointInRectangle(Point taškas)
        }
    }
}