using System;
using System.Linq;

namespace Sausio_11_d_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 UZDUOTIS LESSON 4
            /* Console.WriteLine("Iveskite skaiciu");
             int.TryParse(Console.ReadLine(), out int input);

             for(int i = 1; i <= input; i++)
             {
                 Console.WriteLine(i);
             }*/

            // 3 UZDUOTIS
            /*       string text = "abcdefg";

                   for (int i = text.Length - 1; i >= 0; i--)
                   {
                       Console.Write(text[i]); 
                   }*/

            //4 UZDUOTIS

            /*int number = 5;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }*/

            /*int number = 5;
            int i = 1;

            while (true)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
                i++;
            }
            //if (i == 10)
            //{
              //  break;
            //}*/

            /*bool isAlive = true;

            while (isAlive)
            {
                
                int input = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i<=10; i++)
                {
                    Console.WriteLine($"{input} x {i} = {input * i}");
                }

                Console.WriteLine("Continue y/n?");
                char decision = Convert.ToChar(Console.ReadLine());

                if(decision == 'n')
                {
                    isAlive = false;
                }
            }*/
            //Savarankiskas(2)
            //1 UZDUOTIS

            /*double input = 100000000;
            double sum = 0;

            double chunk = input / 100;
            string progressBar = " ";


            for(double i =1; i<= input; i++)
            {
                sum +=1;

                if(i % chunk == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"{i / chunk}%");
                    progressBar += "#";
                    Console.WriteLine(progressBar);
                }
            }
            Console.WriteLine(sum);*/

            //2 UZDUOTIS Nupiesti piramide is pasirinkto eiluciu kiekio

            /*  int rows = 5;

              for(int space = 0; space<= rows; space++)
              {
                  Console.Write(new string(' ', rows - space));
                  for(int j = 0; j <= space; j++)
                  {
                      Console.Write("* ");
                  }
                  Console.WriteLine();
              }*/
            //3 UZDUOTIS
            /*string text = "word1 word22 word333 word4444";

            string reversedText = string.Join(' ', text.Split(' ').Reverse());

            Console.WriteLine(reversedText);*/

            //4 UZDUOTIS

            /*bool isAlive = true;
            while (isAlive)
            {

                Console.WriteLine("Enter first number:");
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter and operand:");
                char operand = Convert.ToChar(Console.ReadLine());


                switch (operand)
                {
                    case '+':
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case '-':
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case '*':
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case '/':
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        break;
                }
                Console.WriteLine("Do you want to continue? y/n");
                char decision = Convert.ToChar(Console.ReadLine());
                if (decision == 'n') break;
            }*/

            //MASYVAI

            /*int[] array = { 1, 2, 3, 4, 5, 6 };

            Array.Resize(ref array, 10);
            ResizeArray(ref array, 100);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
            public static void ResizeArray(ref int[] array, int newSize)
            {
                int[] newArray = new int[newSize];
                for(int i = 0; i <= array.Length //- 1; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;*/

            //1 UZDUOTIS

            /* int[] array = new int[5];

             for(int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine("Enter a number");
                 array[i] = Convert.ToInt32(Console.ReadLine());
             }
             for(int i = array.Length - 1;i >= 0;i--)
             {
                 Console.WriteLine(array[i]);
             }*/

            /*string numbersText = Console.ReadLine();
              string[] numbers = numbersText.Split(' ');

              int[] numbersReverse = numbers.Select(x => Convert.ToInt32(x)).Reverse().ToArray();
  */
            /*  string numbersString = Console.ReadLine();
              string[] numbersText = numbersString.Split(' ');
              int[] numbers = new int[numbersText.Length];
              for(int i = 0; i < numbersText.Length; i++)
              {
                  numbers[i] = Convert.ToInt32(numbersText[i]);
              }
              int[] newNumbers = new int[numbers.Length];

              foreach(int number in numbers)
              {
                  Console.WriteLine(number);
              }*/

            /*int[] randomNumbers = new int[5];

            Random random = new();

            for(int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 100);
            }
            int smallestNumber = randomNumbers[0];

            foreach(int number in randomNumbers)
            {
                if(number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
            int biggestNumber = randomNumbers[0];

            foreach(int number in randomNumbers)
            {
                if(number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
*/
            /*int[] randomnumbers = new int[5];
            Random random = new Random();
            for (int i = 0; i < randomnumbers.Length; i++)
            {
                randomnumbers[i] = random.Next(1, 25);
                Console.WriteLine(randomnumbers[i]);
            }
            //randomnumbers.Max();
            //randomnumbers.Min();

            //Console.WriteLine(randomnumbers.Min());
            //Console.WriteLine(randomnumbers.Max());*/

            /*int[] firstRandomNumbers = new int[5];
            int[] secondRandomNumbers = new int[5];

            Random random = new();

            for (int i = 0; i < firstRandomNumbers.Length; i++)
            {
                firstRandomNumbers[i] = random.Next(1, 100);
                secondRandomNumbers[i] = random.Next(1, 100);
            }

            int[] appendedArrays = new int [firstRandomNumbers.Length + secondRandomNumbers.Length];
            firstRandomNumbers.CopyTo(appendedArrays, 0);
            secondRandomNumbers.CopyTo(appendedArrays, firstRandomNumbers.Length);*/

        }
    }
}
