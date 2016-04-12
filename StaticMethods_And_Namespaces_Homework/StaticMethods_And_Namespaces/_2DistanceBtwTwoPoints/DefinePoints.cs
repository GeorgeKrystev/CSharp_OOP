using System;
using Point;
class DefinePoints
{
    static void Main(string[] args)
    {
        var pointA = new Point3D(2.5, 6, 9);
        var pointC = new Point3D(-9, 15, 6.66);


        var pointB = new Point3D(28.5, 66, 69);
        var pointD = new Point3D(-99, 85, 6.66);

        DistanceCalculator.CalculateDistance(pointB, pointD);
        DistanceCalculator.CalculateDistance(pointA, pointC);
        //Console.WriteLine();
    }
}

