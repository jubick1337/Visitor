using System;
namespace Visitor
{
    public abstract class GeoStruct
    {
        double[] points;
        int id;
        GeoStruct(double[] points, int id)
        {
            this.points = points;
            this.id = id;
        }
    }
}
