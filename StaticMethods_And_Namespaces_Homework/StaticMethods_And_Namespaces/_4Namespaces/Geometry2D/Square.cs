using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _4Namespaces.Geometry2D
{
    class Square
    {
        private double side;

        public double Side
        {
            get { return this.side; }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("sideA",
                        "Square side should be a positeve non zero number");
                }
                this.side = value;
            }
        }

        public static string Area(double side)
        {
            double result = Math.Pow(side, 2);
            Console.WriteLine(result);
            return String.Format("Area is: {0}",  result);
        }

        public static void  Area6()
        {
            Console.WriteLine(this.side);
        }

        public Square(double side)
        {
            this.Side = side;
        }

        public override string ToString()
        {
             
            return String.Format("The Side of a square is {0}", this.side);
        }
    }
}
