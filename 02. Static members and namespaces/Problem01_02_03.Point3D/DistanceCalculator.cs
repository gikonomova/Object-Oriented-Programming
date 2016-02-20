using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class DistanceCalculator
//Problem 2.Distance Calculator
//Write a static class DistanceCalculator with a static method to calculate the distance between 
//two points in the 3D space. Search in Internet how to calculate distance in the 3D Euclidian space.
{
    public static double CalculateDistance(Point p1, Point p2)
    {

        double deltaX = p1.X - p2.X;
        double deltaY = p1.Y - p2.Y;
        double deltaZ = p1.Z - p2.Z;
        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        return distance;
    }

}

