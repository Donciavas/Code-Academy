using System;

namespace Sausio_13_d_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10_PASKAITA");
            //MyName();
            //PrintNameRepeat();
            //SymbolEqualsHashTag();
            //KMI();
            //NumOfSpaces();
            //IntArraySumAndNum();
            //NumberToPower();
            Problem1();
        }

        private static void PrintName()
        {
            // Parašyti funkciją, kuri išveda į konsolę Jūsų vardą
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine($"Tavo vardas {name}.");
        }

        private static void PrintNameRepeat()
        {
            // Parašyti funkciją, kuri išveda į konsolę vardą
            // tiek kartų kiek yra nurodoma
            Console.WriteLine("Koks tavo vardas?");
            string name = Console.ReadLine();
            Console.WriteLine("Kiek kartų atspausdinti tavo vardą?");
            bool repeatPrint = int.TryParse(Console.ReadLine(), out int index);

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Print #{i}: {name}");
            }
        }

        private static void SymbolEqualsHashTag()
        {
            // Parašyti funkciją, kuri gauna string tipo parametrą.
            // Funkcija turi gražinti eilutę su tiek "#",
            // kiek simbolių yra gautame parametre
            Console.WriteLine("Įveskite string'ą.");
            string inputString = Console.ReadLine();
            inputString.ToCharArray();

            foreach (var item in inputString)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        private static void KMI()
        {
            // Parašti funkciją, kuri gražina KMI
            // Formulė KMI = Masė(Kg)/ ūgis(m)²

            Console.WriteLine("Įveskite svorį (kg).");
            bool weight = double.TryParse(Console.ReadLine(), out double theWeight);
            Console.WriteLine("Įveskite ūgį (cm)");
            bool height = double.TryParse(Console.ReadLine(), out double theHeight);
            Console.WriteLine($"Jūsų KMI yra: {theWeight / Math.Pow(theHeight / 100, 2)}");
        }

        private static void NumOfSpaces()
        {
            // Parašyti funkciją, kuri suskaičiuoja ir gražina,
            // kiek tarpų yra įvestame stringe

            Console.WriteLine("Įveskite sakinį: ");
            string inputString = Console.ReadLine();
            int counter = 0;

            inputString.ToCharArray();

            foreach (var item in inputString)
            {
                if (item == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine($"Sakinyje yra {counter} tarpai.");
        }

        private static void IntArraySumAndCountNum()
        {
            // Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų
            // sumą, bei kiek elementų yra in array

            Console.WriteLine("Kokio dydžio int masyvas?");
            int arraySize = int.Parse(Console.ReadLine());
            int[] smallArray = new int[arraySize];
            for (int i = 0; i < smallArray.Length; i++)
            {
                Console.WriteLine($"Įveskite int: ({i + 1} iš {arraySize})");
                smallArray[i] = int.Parse(Console.ReadLine());
            }
            int sumArray = 0;
            for (int i = 0; i < smallArray.Length; i++)
            {
                sumArray += smallArray[i];
            }
            Console.WriteLine($"Masyvo elementų suma: {sumArray}, masyve yra {smallArray.Length} elementų");

        }

        private static void NumberToPower()
        {
            // Parašyt funkciją, kuri kelia
            // vieną skaičių į antrojo laipsnį
            // Pvz.: 2 ^ 3 = 8

            Console.WriteLine("Įveskite (1) skaičių ir (2) indeksą, kuriuo laipsniu kelsime: ");
            if (!int.TryParse(Console.ReadLine(), out int index1))
            {
                Console.WriteLine("Įvestas ne int");
                Environment.Exit(1);
            }

            if (!int.TryParse(Console.ReadLine(), out int index2))
            {
                Console.WriteLine("Įvestas ne int");
                Environment.Exit(1);
            }

            Console.WriteLine($"{index1} ^ {index2} = {Math.Pow(index1, index2)}");
        }

        private static void Problem1(int firstNum, int secondNum)
        {
            // Parašyti 2 perkrautas funkcijas:
            // 1. Išveda skaičių sumą nuo … iki;
            // 2. Gauna parametrus: int nuo, int iki, bool rodytiTarpineSuma.
            // Pvz.: nuo 1, iki 5;
            // 0+1=1, 1+2=3, 3+4=7, 7+5=12
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                count += i;
            }
            Console.WriteLine(count);
        }
    }
}
