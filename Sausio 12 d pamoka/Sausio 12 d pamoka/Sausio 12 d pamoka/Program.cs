using System;

namespace Sausio_12_d_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*        static void Main(string[] args)
          {
              //6 UZDUOTIS
              int[] random = new int[100];

              Random randomNumbers = new();
              for (int i = 0; i < randomNumbers.Length; i++)
              {
                  randomNumbers[i] = random.Next(1, 10);
              }
              int[] usedNumbers = new int[10];
              int usedNumbersIndex = 0;

              foreach(int number in randomNumbers)
              {
                  if (usedNumbers.Contains(number)) continue;

                  int count = 0;
                  foreach (int numberToCompare in randomNumbers)
                  {

                      if(number == numberToCompare)
                      {
                          count++;
                      }
                  }
                  usedNumbers[usedNumbersIndex] = number;
                  usedNumbersIndex++;
                  Console.WriteLine($"{number} repeated: {count} times");
              }*/

            //9 UZDUOTIS

          /*  int[,] matrix = new int[,] {
            { 1, 2, 3},
            { 2, 3, 4},
            { 3, 4, 5},
        };

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                int sum = 0;

                for (int col = 0; col <= matrix.GetUpperBound(1); col++)
                {
                    
                    sum += matrix[row, col];
                }
                Console.Write(sum);
                Console.WriteLine();
            }*/

        }
    }
}