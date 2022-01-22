using Sausio_18_d_pamoka;
using System;
using System.Collections.Generic;
using Xunit;

namespace Sausio_18_d_pamoka
{
    public class UnitTest1
    {
        [Fact]
        public void Is_Calculations_Correct()
        {
            // Arange
            var Trimester1 = new List<double> { 10, 10, 10 };
            var Trimester2 = new List<double> { 9, 9, 9 };
            var Trimester3 = new List<double> { 8, 8, 8 };

            var allGrades = new Problem1Struct(Trimester1, Trimester2, Trimester3);
            allGrades.PrintValues();

            // Act
            double test1result = allGrades.TrimAvg(Trimester1);
            double test2result = allGrades.TrimAvg(Trimester2);
            double test3result = allGrades.TrimAvg(Trimester3);

            double test4result = allGrades.YearAvg(Trimester1, Trimester2, Trimester3);

            // Asert
            Assert.Equal(10, test1result);
            Assert.Equal(9, test2result);
            Assert.Equal(8, test3result);
            Assert.Equal(9, test4result);
        }
    }
}