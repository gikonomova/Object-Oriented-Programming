using System;
using System.Text;

//Problem 1.
//Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Create appropriate constructors. Override ToString() to enable printing a 3D point.
//Add a private static read-only field in the Point3D class to hold the start of the coordinate system – 
//the point StartingPoint {0, 0, 0}. Add a static property to return the starting point.
public class Point
{
    private double x;
    private double y;
    private double z;
    private static readonly Point startPoint;

    public double X { get { return this.x; } }
    public double Y { get { return this.y; } }
    public double Z { get { return this.z; } }
    static Point()
    {
        Point.startPoint = new Point(0, 0, 0);
    }

    public Point(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static Point StartPoint
    {
        get { return startPoint; }
    }

    public override string ToString()
    {
        string result = "{";
        result += String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        result += "}";

        return result;
    }
}