using Models.RoundType;
using Models.SquareType;
using System;

namespace Sausio_25_d_pamoka_Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sausio 25 d pamoka - Solutions!");
            #region TEORIJA - Review

            // List'ai inicializuojasi konstruktoriuje klasės;
            // A field can be initialized in two ways: In a constructor, or directly upon declaration. The
            // benefit of initialising a field during declaration is that if your class has one or more
            // constructors, you’ll make sure that the field will always be initialised irrespective of
            //which constructor is going to be called.
            //
            //
            //


            #endregion

            #region Assignment1 - PT1
            // 1. Write a class with the name Circle.The class needs one Property with name Radius of type double.
            //    The class needs to have one constructor with parameter radius of type double and it needs to initialize the fields.
            //    In case the radius parameter is less than 0 it needs to set the radius field value to 0.
            //    Write the following method (instance methods):
            //    * Method named getArea without any parameters,
            //    it needs to return the calculated area (radius* radius * PI). For PI use Math.PI constant.
            #endregion
            var circle = new Circle(3.75d);
            circle.GetArea();
            #region Assignment1 - PT2
            // 2. Write a class with the name Cylinder that extends Circle class.
            //    The class needs one field(instance variable) with name height of type double.
            //    In case the height parameter is less than 0 it needs to set the height field value to 0.
            //    Write the following methods(instance methods):
            //    * Method named getVolume without any parameters, it needs to return the calculated volume.
            //    To calculate volume multiply the area with height.
            #endregion
            var cylinder = new Cylinder(7.25d, 5.55d);
            cylinder.GetVolume();
            #region Example
            //TEST EXAMPLE
            // → TEST CODE:
            // Circle circle = new Circle(3.75);
            // Console.WriteLine($"circle.radius= {circle.getRadius()}");
            // Console.WriteLine($"circle.area= {circle.getArea()}");
            // Cylinder cylinder = new Cylinder(5.55, 7.25);
            // Console.WriteLine($"cylinder.radius= {cylinder.getRadius()}");
            // Console.WriteLine($"cylinder.height= {cylinder.getHeight()}");
            // Console.WriteLine($"cylinder.area= {cylinder.getArea()}");
            // Console.WriteLine($"cylinder.volume= {cylinder.getVolume()}");

            // → OUTPUT

            // circle.radius= 3.75
            // circle.area= 44.178646691106465
            // cylinder.radius= 5.55
            // cylinder.height= 7.25
            // cylinder.area= 96.76890771219959
            // cylinder.volume= 701.574580913447
            #endregion
            // some space for console
            Console.WriteLine();
            #region Assignment2 - PT1
            // The Swimming Company has asked you to write an application that calculates the volume of cuboid shaped pools.
            // 1. Write a class with the name Rectangle.The class needs two properties with name width and length both of type double.
            //    The class needs to have one constructor with parameters width and length both of type double and it needs to initialize the fields.
            //    In case the width parameter is less than 0 it needs to set the width field value to 0.
            //    In case the length parameter is less than 0 it needs to set the length field value to 0.
            //    Write the following method:
            //    * Method named getArea without any parameters, it needs to return the calculated area (width* length).
            #endregion
            var rectangle = new Rectangle(5d, 10d);
            rectangle.GetArea();
            #region Assignment2 - PT2
            //2. Write a class with the name Cuboid that extends Rectangle class. The class needs one field(instance variable) with name height of type double.
            //   The class needs to have one constructor with three parameters width, length, and height all of type double.
            //   It needs to call parent constructor and initialize a height field.
            //   In case the height parameter is less than 0 it needs to set the height field value to 0.
            //   Write the following methods):
            //   * Method named getVolume without any parameters, it needs to return the calculated volume.To calculate volume multiply the area with height.
            #endregion
            var cuboid = new Cuboid(5d, 10d, 5d);
            cuboid.GetVolume();
            #region Example
            //  TEST EXAMPLE
            //  → TEST CODE:


            // Rectangle rectangle = new Rectangle(5, 10);
            // System.out.println("rectangle.width= " + rectangle.getWidth());
            // System.out.println("rectangle.length= " + rectangle.getLength());
            // System.out.println("rectangle.area= " + rectangle.getArea());
            // Cuboid cuboid = new Cuboid(5, 10, 5);
            // System.out.println("cuboid.width= " + cuboid.getWidth());
            // System.out.println("cuboid.length= " + cuboid.getLength());
            // System.out.println("cuboid.area= " + cuboid.getArea());
            // System.out.println("cuboid.height= " + cuboid.getHeight());
            // System.out.println("cuboid.volume= " + cuboid.getVolume());

            //→ OUTPUT

            //rectangle.width= 5.0
            //rectangle.length= 10.0
            //rectangle.area= 50.0
            //cuboid.width= 5.0
            //cuboid.length= 10.0
            //cuboid.area= 50.0
            //cuboid.height= 5.0
            //cuboid.volume= 250.0
            #endregion

        }
    }
}