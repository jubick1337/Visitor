using System;
using System.Linq;

namespace Visitor
{
    public class GetAreaVisitor : Visitor
    {
        public GetAreaVisitor()
        {
        }

        public override void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("area equals {0}", (rectangle.points[0] + rectangle.points[1]) * (rectangle.points[2] + rectangle.points[3]));
        }

        public override void VisitSquare(Square square)
        {
            Console.WriteLine("area equals {0}", (square.points[0] + square.points[1]) * (square.points[2] + square.points[3]));
        }

        public override void VisitTriangle(Triangle triangle)
        {
            var p = Enumerable.Sum(triangle.points) / 2;
            Console.WriteLine("are equals {0}", Math.Sqrt(p* (p - triangle.points[0]) * (p - triangle.points[1]) * (p - triangle.points[2])); // Not really
        }
    }
}
