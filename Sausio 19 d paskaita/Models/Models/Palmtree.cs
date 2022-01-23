using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PalmTree // Problem2Struct
    {
        // Sukurti struktūrą Palmė. Public laukai: amžius ir vaisiųKiekis.
        // Abu tik skaitymui. Sukurti Public Metodą pridėti1MenAmziaus().
        // Palmė duoda vaisius nuo 5 iki 12 mėnesio, paskui miršta,
        // t. y. amžius tampa 0. Vaisiu kiekis = amžius*3

        public int PalmAge { get; private set; }
        public int FruitCount { get; private set; }

        public PalmTree(int palmAge, int fruitCount)
        {
            PalmAge = palmAge;
            FruitCount = fruitCount;
        }
        public (int, int) Aging(int palmAge, int fruitCount)
        {
            if (palmAge < 5)
            {
            }
            if (palmAge > 4 && palmAge < 12)
            
            {
                for (int i = palmAge; i > 4 && i < 13; i--)
                {
                    fruitCount += i * 3;
                }
            }
            if (palmAge > 12) { fruitCount = 204; }
            var T1 = (palmAge, fruitCount);
            return T1;

        }

        public void PrintValues()
        {
            Console.WriteLine($"            Palm age (in months): {Aging(PalmAge, FruitCount).Item1}");
            Console.WriteLine($"Total fuits produced: {Aging(PalmAge, FruitCount).Item2} \r\n");
        }
    }
}