using Models;
using System;
using Xunit;

namespace HamburgerTest
{
    public class HamburgerTest
    {
        [Fact]
        public void Test_Or_Function_ItemizeHamburger_Gives_Corect_Answer()
        {
            Hamburger hamburger = new Hamburger("Basic", "Sausage", "White", 3.56);
            hamburger.AddHamburgerAddition1("Tomato", 0.27);
            hamburger.AddHamburgerAddition2("Lettuce", 0.75);
            hamburger.AddHamburgerAddition3("Cheese", 1.13);

            Assert.Equal(5.71, hamburger.ItemizeHamburger());
        }
    }
}