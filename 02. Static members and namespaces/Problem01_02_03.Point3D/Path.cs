using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Path
//Problem 3.Paths
//Create a class Path3D to hold a sequence of points in 3D space. 
//Create a static class Storage with static methods to save and load paths from a text file. 
//Use a file format of your choice. Ensure you close correctly all files with the "using" statement.

{
    private List<Point> points = new List<Point>();

    public Path(params Point[] points)
    {
        if (points.Length > 0)
        {
            this.points.AddRange(points);
        }
    }

    public void AddPoint(Point point)
    {
        this.points.Add(point);
    }

    public override string ToString()
    {
        return string.Join(" ", this.points);
    }
}