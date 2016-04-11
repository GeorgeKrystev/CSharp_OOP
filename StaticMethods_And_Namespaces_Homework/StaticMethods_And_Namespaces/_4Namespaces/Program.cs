using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Namespaces.Geometry2D;

namespace _4Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Square demo = new Square(6);
            Console.WriteLine(demo);
            Console.WriteLine(Square.Area(6));
        }
    }
}
