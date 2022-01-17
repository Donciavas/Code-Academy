using System;
using System.Linq;
using System.Collections.Generic;

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
            //SymbolEqualsHashTag("WithoutInput"); // <-- OVERLOAD
            //KMI();
            //KMI(200, 100); // <-- OVERLOAD
            //NumOfSpaces();
            //Console.WriteLine(NumOfSpaces("Pa vyz dys")); // <-- OVERLOAD
            /*IntArraySumAndCountNum();
              int[] array = { 1, 2, 3, 4, 5 };
              Console.WriteLine(IntArraySumAndCountNum(array)); // <-- OVERLOAD nepralenda tuplas*/
            //NumberToPower();
            //Console.WriteLine($"2 ^ 3 = " + NumberToPower(2, 3)); // <-- OVERLOAD
            //OverloadFunctions(0, 5, true); // <-- funkcijoje yra int, int; overload su bool();
            //StringBackwards();
            //Fibonacci();
            //NumAsAloneSum();
            RecFuncToFactorial();
        }

        public static int Factorial(int x)
        {
            if (x == 0)
            {
                return x;
            }

            return x * Factorial(x - 1);
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

        public static void SymbolEqualsHashTag(string thing)
        {
            // Parašyti funkciją, kuri gauna string tipo parametrą.
            // Funkcija turi gražinti eilutę su tiek "#",
            // kiek simbolių yra gautame parametre
            string inputString = thing;
            Console.WriteLine(inputString);
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

        public static void KMI(int height, int weight)
        {
            // Parašti funkciją, kuri gražina KMI
            // Formulė KMI = Masė (Kg)/ūgis(m)²

            Console.WriteLine($"Jūsų KMI yra: {weight / Math.Pow(height / 100, 2)}");
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

        public static int NumOfSpaces(string someString)
        {
            // Parašyti funkciją, kuri suskaičiuoja ir gražina,
            // kiek tarpų yra įvestame stringe

            Console.WriteLine(someString);
            int counter = 0;

            someString.ToCharArray();

            foreach (var item in someString)
            {
                if (item == ' ')
                {
                    counter++;
                }
            }
            return counter;
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

        public static int IntArraySumAndCountNum(int[] smallArray)
        {
            // Parašyti funkciją, kuri paima int[] parametrą ir išveda elementų
            // sumą, bei kiek elementų yra in array

            int sumArray = 0;
            for (int i = 0; i < smallArray.Length; i++)
            {
                sumArray += smallArray[i];
            }

            (int, int) tuple = (1, 2);
            Console.WriteLine(tuple);

            (int, int) tuple2 = (sumArray, smallArray.Length);
            Console.WriteLine(tuple2);

            return sumArray;
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

        public static double NumberToPower(double index1, double index2)
        {
            // Parašyt funkciją, kuri kelia
            // vieną skaičių į antrojo laipsnį
            // Pvz.: 2 ^ 3 = 8

            return Math.Pow(index1, index2);
        }

        public static void OverloadFunctions(int firstNum, int secondNum)
        {
            // Parašyti 2 perkrautas funkcijas:
            // 1. Išveda skaičių sumą nuo … iki;
            // 2. Gauna parametrus: int nuo, int iki, bool rodytiTarpineSuma.
            // Pvz.: nuo 1, iki 5;
            // 0+1=1, 1+2=3, 3+3=6, 6+4=10

            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                count += i;
            }
            Console.WriteLine(count);
        }

        public static void OverloadFunctions(int firstNum, int secondNum, bool showMid)
        {
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine($"{count} + {i} = {count + i}");
                    count += i;
                }
            }

        }

        public static void StringBackwards()
        {
            // Palindromas - (gr.palindromos - bėgantis atgal, grįžtantis):
            // 1.žodis, eilėraštis arba frazė, skaitomi iš kairės į dešinę ir
            // iš dešinės į kairę, išlaikantys tą pačia prasmę
            // pvz., lietuvių k. žodis: „Savas“, sakinys „Abu gaišo po šia guba“

            // Jei išvesti string'ą atvirkščiai: 

            Console.WriteLine("įveskite sakinį, kuris bus atspausdintas atbulai: ");
            string palindrome = Console.ReadLine();

            palindrome.ToCharArray();

            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                Console.Write(palindrome[i]);
            }
            Console.WriteLine();
        }

        public static void Fibonacci()
        {
            // Padaryti funkciją, kuri parodo X Fibonačio skaičių. Seka prasideda
            // šiais skaičiais 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233…
            // kiekvienas šios sekos skaičius lygus dviejų prieš jį einančių skaičių sumai

            Console.WriteLine("Iki kelinto Fibonacci skaičiaus spaustinti?");// <-- Reikia paduoti int'ą į funckiją, int yra index skaičiaus # Fibonacci eilėje
            if (!int.TryParse(Console.ReadLine(), out int indexer))
            {
                Console.WriteLine("Netinkama įvestis!");
                Environment.Exit(1);
            }

            for (int i = 0; i < indexer; i++)
            {
                Console.WriteLine(FibonacciIterration(i));
            }
        }

        public static int FibonacciIterration(int index)
        {
            // Iš esmės reikia susikurti generatorių cikle
            // ir targetinti tam tikrą max index'ą cikle

            int x = 0;
            int y = 1;
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233…
            for (int i = 0; i < index; i++)
            {
                int cache = x;
                x = y;
                y = cache + y;
            }
            return x;
        }

        public static void NumAsAloneSum()
        {
            // Parašyti funkciją, kuri suskaičiuoja atskirų
            // bet kokio skaičiaus skaitmenų sumą
            Console.WriteLine("Programa apskaičiuos atskirų įvesto skaitmens skaitmenų sumą");
            Console.WriteLine("Įveskite skaičių: ");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Netinkama įvestis!");
                Environment.Exit(1);
            }
            char[] tempCharArray = num.ToString().ToCharArray();


            List<char> splitNum = new();
            for (int i = 0; i < tempCharArray.Length; i++)
            {
                splitNum.Add(tempCharArray[i]);
            }

            int sum = 0;
            Console.WriteLine($"Skaičiaus: {num}, pavienių skaičių: ");
            foreach (var item in splitNum)
            {
                sum += int.Parse(item.ToString());
                Console.Write($"{item} ");
            }
            Console.WriteLine($"suma yra {sum} ");
            Console.WriteLine();

            // 100% yra normalesnis sprendimas;
        }
        public static void RecFuncToFactorial()
        {
            // Parašyti rekursinę funkciją faktorialo skaičiavimui.
            // Faktorialas – natūrinių skaičių sandauga
            // nuo 1 iki natūrinio skaičiaus (imtinai).
            // Žymima šauktuko (!) ženklu. Pvz: 5! = 1*2*3*4*5=120;

            // Nematau skirtumo nuo 8 užduoties, '+' į '*' pakeiti ir viskas:
            Console.WriteLine("Įveskite skaičių faktorialo išvedimui: ");
            //int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            //int count = firstNum;
            int count = 1;

            //for (int i = firstNum; i <= secondNum; i++)
            for (int i = 1; i <= secondNum; i++)
            {
                if (i != 1)
                {
                    Console.WriteLine($"{count} * {i} = {count * i}");
                    count *= i;
                }
            }
            Console.WriteLine(count);
        }
    }
}
