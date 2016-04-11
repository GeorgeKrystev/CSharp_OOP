using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Point;

namespace _3Path3D
{
    class Path3D
    {
        private const string NumberMatcher = @"([-+]?[0-9]*\.?[0-9])";
        private const string PointMatcher = @"Point\s*\((.*?),\s*(.*?),\s*(.*?)\)";
        private List<Point3D> path = new List<Point3D>();

        public Path3D(List<Point3D> path = null) 
        {
            this.path = path;
        }

        public List<Point3D> Path
        {
            get { return this.path; }
            set
            {
                this.path = value ?? new List<Point3D>();
            }
        }

        public void AddPointToPath(Point3D point)
        {
            var currentPath = this.Path;
            currentPath.Add(point);
            this.Path = currentPath;
        }

        public static double CalcPathDistance(List<Point3D> path)
        {
            foreach (var item in path)
            {
                string pathAsStr = path.ToString();
                Console.WriteLine(path);
                foreach (Match match in Regex.Matches(pathAsStr, PointMatcher))
                {
                    double xCoordinate = double.Parse(match.Groups[1].Value);
                    double yCoordinate = double.Parse(match.Groups[2].Value);
                    double zCoordinate = double.Parse(match.Groups[3].Value);

                    Console.WriteLine(xCoordinate + yCoordinate + zCoordinate);
                    //pointsInPath.Add(new Point3D(xCoordinate, yCoordinate, zCoordinate));
                }
            }


            public override string ToString()
            {
                string result = "Path: \r\n";

                foreach (var poin in this.Path)
                {
                    result += "\t" + poin.ToString() + "\r\n";
                }
                //return result;
            }
        //Console.WriteLine(path);
        double result = 0;
            return result;
        }


        public override string ToString()
        {
            string result = "Path: \r\n";

            foreach (var poin in this.Path)
            {
                result += "\t" + poin.ToString() + "\r\n";
            }
            return result;
        }
    }

}
