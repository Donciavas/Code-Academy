using System;

namespace Sausio_3_pamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#1 UZDUOTIS

            char letter, letter1, letter2;

            Console.Write("Input letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
*/
            // 2 variantas

            /*string input = "abc";

            char c = Convert.ToChar(input.Substring(2, 1));
            char b = Convert.ToChar(input.Substring(1, 1));
            char a = Convert.ToChar(input.Substring(0, 1));

            Console.WriteLine($"{c}{b}{a}");*/

            /*#2 UZDUOTIS*/

            /*double distance, sec, kph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToDouble(Console.ReadLine());

            kph = (distance / 1000.0d) / (sec / 3600d);

            Console.WriteLine("Your speed in km/h is {0}", kph);*/


            // 2 variantas

            /*int meters = 100;
            int seconds = 8;

            double meterPerSecond = meters / seconds;

            metersPerSecond */

            /*#3 UZDUOTIS Pakelk x 32 kartus praso ivesti rutulio diametra, o isveda plota ir turi*/

            /*int x = 2;
            int y = int.MaxValue;

            Console.WirteLine(Math.Pow(x, 32));
            Console.WriteLine(y);*/

            /*double d = 10;
            double r = d / 2;
            double surfaceArea = 4 * Math.PI * Math.Pow(r, d);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);

            Console.WriteLine(surfaceArea);*/

            /*#4 UZDUOTIS*/

            /*int x = 1;
            int y = 2;

            //bool isXEven = (x % 2 == 0);
            //bool isYEven = (y % 2 == 0);

            bool isEven = ((x % 2 == 0) && (y % 2 == 0));

            Console.WriteLine((x % 2 == 0) && (y % 2 == 0));
*/
            //#1 UZDUOTIS
            /*Console.WriteLine(new String('1', 1));
            Console.WriteLine(new String('1', 2));
            Console.WriteLine(new String('1', 3));*/

            //#2 UZDUOTIS

            /*var username = "username";
            var password = "password";

            var usernameInput = Console.ReadLine();
            var passwordInput = Console.ReadLine();

            bool isCorrect = usernameInput.Equals(username) && passwordInput.Equals(password);
            int numberOfTries = isCorrect ? 3 : 0;*/

            //#3 UZDUOTIS

            //tiesiog matematika

            //#4 UZDUOTIS

            /*var number = 12345.5D;
            short number2 = Convert.ToInt16(number);
            Console.WriteLine(number2);*/

            //#1 Salygu uzduotis

            /*Console.WriteLine("Iveskite grupes nariu kieki:");

            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("int.TryParse failed on user input");
                Environment.Exit(0);
            }
            if (input == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if (input == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if ((input > 2 && input < 10))
            {
                Console.WriteLine("Tai ansamblis");
            }
            else if (input > 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");
            }
            else if (input == 10)
            {
                Console.WriteLine("Tai vis dar ansamblis");
            }
            else
            {
                Console.WriteLine("int.TryParse failed on user input");
                Environment.Exit(1);*/

            /*Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= inputNumber; i++)
                sum += 1;
            { 
            }
        Console.Write(sum);*/


        }
    }
}
