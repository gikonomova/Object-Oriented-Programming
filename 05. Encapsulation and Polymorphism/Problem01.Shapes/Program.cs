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
    class Program
    {
        static void Main(string[] args)
        {
            BasicShape[] figures = new BasicShape[]
            {
            new Rectangle(3, 5.5),
            new Circle(6),
            new Rhombus(7, 10.4),
            new Circle(5.5),
            new Rectangle(9.6, 12)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.CalculateArea());
                Console.WriteLine(figure.CalculateParameter());
            }
            Console.ReadLine();
        }
    }
}
