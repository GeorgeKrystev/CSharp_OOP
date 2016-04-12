using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;

namespace _3Path3D
{
    class PathTesting
    {
        static void Main(string[] args)
        {
            List<Point3D> listOfPoints = new List<Point3D>();

            listOfPoints.Add(new Point3D(35, 65, 89));
            listOfPoints.Add(new Point3D(35, 6, 9));
            listOfPoints.Add(new Point3D(3, 65, 89));

            Path3D path = new Path3D(listOfPoints);
            //Console.WriteLine(path);
            Console.WriteLine(Path3D.CalcPathDistance(listOfPoints));
        }
    }
}
