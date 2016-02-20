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
    public abstract class BasicShape : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
       
        public abstract double CalculateArea();        
        public abstract double CalculateParameter();
        
    }
}
