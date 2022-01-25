using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RoundType
{
    public class Circle
    // 1.Write a class with the name Circle.The class needs one Property with name Radius of type double.
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            //   The class needs to have one constructor with parameter radius of type double and it needs to initialize the fields.
            Radius = CheckIfBellow0(radius);
        }
        public double CheckIfBellow0(double radius)
        {
            //   In case the radius parameter is less than 0 it needs to set the radius field value to 0.
            if (radius < 0)
            {
                radius = 0;
            }
            return radius;
        }

        //    Write the following method (instance methods):
        //    * Method named getArea without any parameters,
        //    it needs to return the calculated area (radius* radius * PI). For PI use Math.PI constant.

        public void GetArea()
        {
            Console.WriteLine($"{Radius} * {Radius} * PI = {Radius * Radius * Math.PI}");
        }
        public double GetAreaData()
        {
            return (Radius * Radius * Math.PI);
        }

        //public class Cylinder : Circle

        // 2. Write a class with the name Cylinder that extends Circle class.
        //    The class needs one field(instance variable) with name height of type double.
        //    In case the height parameter is less than 0 it needs to set the height field value to 0.
        //    Write the following methods(instance methods):
        //    * Method named getVolume without any parameters, it needs to return the calculated volume.
        //    To calculate volume multiply the area with height.
    }
}