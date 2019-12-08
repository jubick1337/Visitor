using System;
namespace Visitor
{
    public class Square : GeoStruct
    {
        double[] points;
        int id;

        public Square(double[] points, int id)
        {
            if (points.Length != 4)
                throw new Exception("not a square");
            this.points = points;
            this.id = id;
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitSquare(this);
        }
    }
}
