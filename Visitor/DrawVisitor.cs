using System;
namespace Visitor
{
    public class DrawVisitor : Visitor
    {
        double x, y;
        public DrawVisitor(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override void VisitRectangle(Rectangle rectangle)
        {
            Console.WriteLine("Draw rectangle at {0}, {1} with id {2}", x,y, rectangle.Id);
        }

        public override void VisitSquare(Square square)
        {
            Console.WriteLine("Draw square at {0}, {1} with id {2}", x, y, square.Id);
        }

        public override void VisitTriangle(Triangle triangle)
        {
            Console.WriteLine("Draw triangle at {0}, {1} with id {2}", x, y, triangle.Id);
        }
    }
}
