using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SquareType
{
    public class Rectangle
    {
        // 1. Write a class with the name Rectangle.The class needs two properties with name width and length both of type double.
        public double Width { get; set; }
        public double Lenght { get; set; }

        public Rectangle(double width, double lenght)
        //    The class needs to have one constructor with parameters width and length both of type double and it needs to initialize the fields.
        {
            Width = CheckIfBellow0(width);
            Lenght = CheckIfBellow0(lenght);
        }
        public double CheckIfBellow0(double variable)
        {
            //    In case the width parameter is less than 0 it needs to set the width field value to 0.
            //    In case the length parameter is less than 0 it needs to set the length field value to 0.
            if (variable < 0)
            {
                variable = 0;
            }
            return variable;
        }
        public void GetArea()
        {
            //    * Method named getArea without any parameters, it needs to return the calculated area (width* length)
            Console.WriteLine($"Height({Lenght}) * Width({Width}) = {Lenght * Width}");
        }
        public double GetAreaData()
        {
            return (Lenght * Width);
        }
    }
}
