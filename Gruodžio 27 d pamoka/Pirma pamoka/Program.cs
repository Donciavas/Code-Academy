using System;

namespace Pirma_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 UZDUOTIS Swap values between two variables.

            //int a = 7, b = 9;
            //Console.WriteLine("Before swap a= " + a + " b= " + b);
            //a = a * b; //a=63 (7*9)      
            //b = a / b; //b=7 (63/9)      
            //a = a / b; //a=9 (63/7)    
            //Console.Write("After swap a= " + a + " b= " + b);

            // 2 UZDUOTIS  Take 2 input variables from console and output the result of ‘==’ of them (true/false).

            //int x;
            //int y;
            //String TF = "";

            //Console.WriteLine("Enter first digit");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second digit");
            //y = Convert.ToInt32(Console.ReadLine());

            //bool result = x==y;
            //Console.WriteLine(x == y);

            // 3 UZDUOTIS Take 2 input variables from console then add 1 to the first one and subtract 1 from the second one.

            //int x;
            //int y;
            //String TF = "";

            //Console.WriteLine("Enter first digit");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second digit");
            //y = Convert.ToInt32(Console.ReadLine());
            //x = ++x;
            //y = --y;
            //Console.Write($"After add & subtract x= {x} y= {y}");

            // 4 UZDUOTIS Calculate rectangle perimeter and area.

            //int l, w, area, perimeter;
            //Console.Write("Length : ");
            //l = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Width : ");
            //w = Convert.ToInt32(Console.ReadLine());
            //area = l * w;
            //perimeter = 2 * (l + w);
            //Console.WriteLine("Area of Rectangle : " + area);
            //Console.WriteLine("Perimeter of Rectangle : " + perimeter);
            //Console.ReadKey();

            //5 UZDUOTIS

            /*string input = Console.ReadLine();
            bool isEmpty = string.IsNullOrWhiteSpace(input);
            Console.WriteLine(isEmpty);*/

            //PAPILDOMOS EILUTES

            /*string nullStr = null;
            // print True
            Console.WriteLine(String.IsNullOrEmpty(nullStr));

            string emptyStr1 = "";
            // print True
            Console.WriteLine(String.IsNullOrEmpty(emptyStr1));

            string emptyStr2 = String.Empty;
            // print True
            Console.WriteLine(String.IsNullOrEmpty(emptyStr2));

            string str = "some text";
            // print False
            Console.WriteLine(String.IsNullOrEmpty(str));*/

            //6 UZDUOTIS Check if a number is lesser than 0.

            //Console.WriteLine("Enter your number");
            //int x;
            //x = Convert.ToInt32(Console.ReadLine());
            //string comparison = x < 0 ? "is lower than null" : "is greater than null";
            //Console.WriteLine(comparison);

            //Second solution

            //Console.WriteLine("Please write your number:");
            //int n = int.Parse(Console.ReadLine());

            //if ((n > 0))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //   Console.WriteLine("False");
            //}

            //7 UZDUOTIS Take name and lastname as separate inputs and output them in one line.

            /*string name, lastname; 

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            lastname = Console.ReadLine();
            Console.WriteLine($"{name} {lastname}");*/

            //PAPILDOMOS UZDUOTYS

            //ALL TO LOWERCASE

            /*Console.Write("Enter any text: ");
            string theText = Console.ReadLine();
            string convertedText = theText.ToLower();
            Console.WriteLine(convertedText);

            Console.ReadLine();

            //SKAICIAUS LIEKANA IS 3 ir 7

            Console.Write("Enter any number: ");
            int anyNumber = Convert.ToInt32(Console.ReadLine());

            string liekanaIs3 = anyNumber % 3 == 0 ? $"Skaicius {anyNumber} yra 3 kartorinis" : "";
            string liekanaIs7 = anyNumber % 7 == 0 ? $"Skaicius {anyNumber} yra 7 kartotinis" : "";

            Console.WriteLine(liekanaIs3);
            Console.WriteLine(liekanaIs7);*/

        }
    }
}