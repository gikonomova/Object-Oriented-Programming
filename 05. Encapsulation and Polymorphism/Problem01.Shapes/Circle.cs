using Problem01.Shapes.Interfaces;
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
    class Circle : BasicShape, IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be a possitive number!");
                }
                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double CalculateParameter()
        {
            return Math.PI * this.Radius * 2;
        }
    }
}
