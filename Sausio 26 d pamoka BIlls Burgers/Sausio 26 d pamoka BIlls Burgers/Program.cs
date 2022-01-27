using Models;
using Sausio_26_d_pamoka_Bills_Burgers;
using System;

namespace Sausio_26_d_pamoka_BIlls_Burgers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson 14 task 1");

            Hamburger hamburger = new Hamburger("Basic", "Sausage", "White", 3.56);
            hamburger.AddHamburgerAddition1("Tomato", 0.27);
            hamburger.AddHamburgerAddition2("Lettuce", 0.75);
            hamburger.AddHamburgerAddition3("Cheese", 1.13);
            Console.WriteLine("Total Burger price is " + hamburger.ItemizeHamburger());
            Console.WriteLine();
            Console.ReadKey();
            HealthyBurger healthyBurger = new HealthyBurger("Bacon", 5.67);
            healthyBurger.AddHamburgerAddition1("Egg", 5.43);
            healthyBurger.AddHealthyAddition1("Lentils", 3.41);
            Console.WriteLine("Total Healthy Burger price is  " + healthyBurger.ItemizeHamburger());
            Console.WriteLine();
            Console.ReadKey();
            DeluxeBurger db = new DeluxeBurger();
            db.AddHamburgerAddition3("Should not do this", 50.53);
            Console.WriteLine("Total Deluxe Burger price is " + db.ItemizeHamburger());
            Console.WriteLine();
            Console.ReadKey();

        }



    }
}