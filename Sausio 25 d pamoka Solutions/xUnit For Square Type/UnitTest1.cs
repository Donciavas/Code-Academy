using Models.SquareType;
using System;
using Xunit;

namespace xUnit_For_Square_Type
{
    public class UnitTest1
    {
        [Fact]
        public void Test_to_assert_caculation_correctness()
        {
            // Arange
            var rectangle = new Rectangle(5d, 7d);
            var cuboid = new Cuboid(3d, 5d, 6d);
            // Act
            double test1result = rectangle.GetAreaData();
            double test2result = cuboid.GetVolumeData();
            // Asert
            Assert.Equal(35, test1result);
            Assert.Equal(90, test2result);
        }
    }
}