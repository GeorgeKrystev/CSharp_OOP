using System;
using System.Collections.Generic;  
using Point;

namespace _3Path3D
{
    class Path3D
    {
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
