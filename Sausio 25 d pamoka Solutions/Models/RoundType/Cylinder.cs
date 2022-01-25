using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RoundType
{// 2. Write a class with the name Cylinder that extends Circle class.
    public class Cylinder : Circle
    {
        //    The class needs one field(instance variable) with name height of type double.
        public double Height { get; set; }

        public Cylinder(double height, double radius) : base(radius)
        {
            Height = CheckIfBellow0(height);
        }

        public double CheckIfBellow0(double height)
        {
            //    In case the height parameter is less than 0 it needs to set the height field value to 0.
            if (height < 0)
            {
                height = 0;
            }
            return height;
        }
        //    Write the following methods(instance methods):
        //    * Method named getVolume without any parameters, it needs to return the calculated volume.
        //    To calculate volume multiply the area with height.
        public void GetVolume()
        {
            Console.WriteLine($"{Radius} * {Radius} * PI * {Height} * PI = {GetAreaData() * Height}");
        }
    }
}