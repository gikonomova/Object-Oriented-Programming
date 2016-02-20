using System;

//Define an interface IShape with two abstract methods: CalculateArea() and CalculatePerimeter().
//Define an abstract class BasicShape implementing IShape and holding width and height. 
//Leave the methods CalculateArea() and CalculatePerimeter() abstract.
//Define two new BasicShape subclasses: Rhombus and Rectangle that implement the abstract methods CalculateArea()
//and CalculatePerimeter().
//Define a class Circle implementing IShape with a suitable constructor.
//Create an array of different shapes (Circle, Rectangle, Rhombus) and test the behavior of the CalculateSurface()
//and CalculatePerimeter() methods.

namespace Problem01.Shapes
{
    class Rectangle : BasicShape
    {
         public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculateParameter()
        {
            return 2 * (this.Height + this.Width);
        }
    }
}
