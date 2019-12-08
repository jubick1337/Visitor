using System;
namespace Visitor
{
    public class Rectangle : GeoStruct
    {
        double[] points;
        int id;

        public Rectangle(double[] points, int id)
        {
            if (points.Length != 4)
                throw new Exception("not a rectagle");
            this.points = points;
            this.id = id;
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitRectangle(this);
        }
    }
}
