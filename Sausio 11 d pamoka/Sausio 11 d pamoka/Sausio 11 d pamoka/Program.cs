using System;

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

            double input = 100000000;
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
            Console.WriteLine(sum);
        }
    }
}
