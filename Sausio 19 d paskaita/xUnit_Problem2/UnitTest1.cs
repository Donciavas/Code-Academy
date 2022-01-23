using System;
using Models;
using Xunit;

namespace xUnit_Problem2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var Palm1 = new PalmTree(2, 0);
            var Palm2 = new PalmTree(4, 0);
            var Palm3 = new PalmTree(8, 0);
            var Palm4 = new PalmTree(9, 0);
            var Palm5 = new PalmTree(7, 0);

            // Act
            (int, int) test1 = Palm1.Aging(Palm1.PalmAge, Palm1.FruitCount);
            (int, int) test2 = Palm2.Aging(Palm2.PalmAge, Palm2.FruitCount);
            (int, int) test3 = Palm3.Aging(Palm3.PalmAge, Palm3.FruitCount);
            (int, int) test4 = Palm4.Aging(Palm4.PalmAge, Palm4.FruitCount);
            (int, int) test5 = Palm5.Aging(Palm5.PalmAge, Palm5.FruitCount);

            // Assert
            Assert.Equal((5, 204), test1);
            Assert.Equal((5, 204), test2);
            Assert.Equal((8, 150), test3);
            Assert.Equal((9, 126), test4);
            Assert.Equal((7, 171), test5);
        }
    }
}