using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HealthyBurger : Hamburger
    {
        public string HealthyExtra1Name { get; private set; }
        public double HealthyExtra1Price { get; private set; }
        public string HealthyExtra2Name { get; private set; }
        public double HealthyExtra2Price { get; private set; }


        public HealthyBurger(string meat, double price) : base(meat, price)
        {
            Name = "Healthy";
            BreadRollType = "Brown rye";
            Console.WriteLine($"{Name} hamburger on a {BreadRollType} roll with {Meat}, price is {Price}");

        }

        public void AddHealthyAddition1(string healthyExtra1Name, double healthyExtra1Price)
        {
            HealthyExtra1Name = healthyExtra1Name;
            HealthyExtra1Price = healthyExtra1Price;
            Console.WriteLine($"Added {HealthyExtra1Name} for an extra {HealthyExtra1Price}");
        }
        public void AddHealthyAddition2(string healthyExtra2Name, double healthyExtra2Price)
        {
            HealthyExtra2Name = healthyExtra2Name;
            HealthyExtra2Price = healthyExtra2Price;
            Console.WriteLine($"Added {HealthyExtra2Name} for an extra {HealthyExtra2Price}");
        }

        public override double ItemizeHamburger()
        {
            return Math.Round(Price + Addition1Price + Addition2Price + Addition3Price + Addition4Price + HealthyExtra1Price + HealthyExtra2Price, 2);
        }
    }
}