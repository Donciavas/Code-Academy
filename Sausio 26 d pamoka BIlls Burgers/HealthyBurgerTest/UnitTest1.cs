using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HealthyBurgerTest
{
    public class HealthyBurgerTest
    {
        [Fact]
        public void Test_Or_Function_ItemizeHamburger_Gives_Corect_Answer()
        {
            HealthyBurger healthyBurger = new HealthyBurger("Bacon", 5.67);
            healthyBurger.AddHamburgerAddition1("Egg", 5.43);
            healthyBurger.AddHealthyAddition1("Lentils", 3.41);

            Assert.Equal(14.51, healthyBurger.ItemizeHamburger());
        }
    }
}