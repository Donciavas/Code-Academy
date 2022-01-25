using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.SquareType
{
    public class Cuboid : Rectangle
    {
        //2. Write a class with the name Cuboid that extends Rectangle class. The class needs one field(instance variable) with name height of type double.
        public double Height { get; set; }
        //   The class needs to have one constructor with three parameters width, length, and height all of type double.
        //   It needs to call parent constructor and initialize a height field.
        //   In case the height parameter is less than 0 it needs to set the height field value to 0. <-- kopijuoju metodą iš tėvinės
        public Cuboid(double height, double width, double lenght) : base(width, lenght)
        {
            Height = CheckIfBellow0(height);
        }
        //   Write the following methods):
        //   * Method named getVolume without any parameters, it needs to return the calculated volume.To calculate volume multiply the area with height.
        public void GetVolume()
        {
            Console.WriteLine($"Volume is calculated by multiplyng height({Height}) width({Width}) and lenght({Lenght}) = {GetAreaData() * Height}");
        }
    }
}