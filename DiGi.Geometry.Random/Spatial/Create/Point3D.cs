using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static Point3D Point3D(BoundingBox3D boundingBox3D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            Point3D min = boundingBox3D.Min;
            if (min == null)
            {
                return null;
            }

            Point3D max = boundingBox3D.Max;
            if (max == null)
            {
                return null;
            }

            return Point3D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), new Range<double>(min.Z, max.Z), seed, tolerance);
        }

        public static Point3D Point3D(Range<double> x, Range<double> y, Range<double> z, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            return new Point3D(DiGi.Core.Query.Random(x, seed, tolerance), DiGi.Core.Query.Random(y, seed, tolerance), DiGi.Core.Query.Random(z, seed, tolerance));

        }

        public static Point3D Point3D(Polygon3D polygon3D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if(polygon3D == null)
            {
                return null;
            }

            Plane plane = polygon3D.Plane;
            if (plane == null)
            {
                return null;
            }

            Point2D point2D = Planar.Random.Create.Point2D(polygon3D.Geometry2D, seed, tolerance);
            if(point2D == null)
            {
                return null;
            }

            return plane.Convert(point2D);

        }
    }
}
