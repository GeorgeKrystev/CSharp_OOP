using System; 
 
class CreatePoints
{
    static void Main(string[] args)
    {
        Point3D testPoint = new Point3D(16, 6.6, 78.6);

        Console.WriteLine(testPoint);
        Console.WriteLine(Point3D.StartingPoint);
    }
} 
