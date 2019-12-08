using System;
namespace Visitor
{
    public class Triangle : GeoStruct
    {
        double[] points;
        int id;

        public Triangle(double[] points, int id)
        {
            if (points.Length != 3)
                throw new Exception("not a triangle");
            this.points = points;
            this.id = id;
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitTriangle(this);
        }
    }
}
