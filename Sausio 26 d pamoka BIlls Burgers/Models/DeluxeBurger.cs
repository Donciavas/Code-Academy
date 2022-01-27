using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_26_d_pamoka_Bills_Burgers
{
    public class DeluxeBurger : Hamburger

    {
        public DeluxeBurger()
        {

            Name = "DeluxBurger";
            BreadRollType = "White";
            Meat = "Sausage & Bacon";
            Price = 14.54;
            Console.WriteLine($"{Name} hamburger on a {BreadRollType} roll with {Meat}, price is {Price}");
        }

        public new void AddHamburgerAddition1(string addition1Name, double addition1Price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }
        public new void AddHamburgerAddition2(string addition2Name, double addition2Price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }
        public new void AddHamburgerAddition3(string addition3Name, double addition3Price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }
        public new void AddHamburgerAddition4(string addition4Name, double addition4Price)
        {
            Console.WriteLine($"Cannot not add additional items to a deluxe burger");
        }

        public override double ItemizeHamburger()
        {
            double chips = 2.75;
            double drink = 1.81;
            Console.WriteLine($"Added Chips for an extra {chips}");
            Console.WriteLine($"Added Drink for an extra {drink}");
            return Math.Round(Price + chips + drink, 2);
        }
    }
}