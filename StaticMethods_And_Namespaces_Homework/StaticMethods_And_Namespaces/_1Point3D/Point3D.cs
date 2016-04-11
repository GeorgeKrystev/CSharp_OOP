using System; 

class Point3D
{
    private double x, y, z;
    private static readonly Point3D straightPoint = new Point3D(0,0,0);

    public static Point3D StartingPoint
    {
        get { return straightPoint; }
    }

    public double X
    {
        get { return this.x; }
        set
        {
            this.x = value;
        }
    }

    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public double Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    public Point3D(double x = 0, double y = 0, double z = 0)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        return String.Format(
            "Point ({0}, {1}, {2})", this.x, this.y, this.z);
    }
} 