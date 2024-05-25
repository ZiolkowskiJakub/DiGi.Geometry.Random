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

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point3D(boundingBox3D, random, tolerance);
        }

        public static Point3D Point3D(BoundingBox3D boundingBox3D, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
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

            return Point3D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), new Range<double>(min.Z, max.Z), random, tolerance);
        }

        public static Point3D Point3D(Range<double> x, Range<double> y, Range<double> z, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point3D(x, y, z, random, tolerance);

        }

        public static Point3D Point3D(Range<double> x, Range<double> y, Range<double> z, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return new Point3D(DiGi.Core.Query.Random(random, x, tolerance), DiGi.Core.Query.Random(random, y, tolerance), DiGi.Core.Query.Random(random, z, tolerance));
        }

        public static Point3D Point3D(Polygon3D polygon3D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if(polygon3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point3D(polygon3D, random, tolerance);
        }

        public static Point3D Point3D(Polygon3D polygon3D, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygon3D == null)
            {
                return null;
            }

            Plane plane = polygon3D.Plane;
            if (plane == null)
            {
                return null;
            }

            Point2D point2D = Planar.Random.Create.Point2D(polygon3D.Geometry2D, random, tolerance);
            if (point2D == null)
            {
                return null;
            }

            return plane.Convert(point2D);

        }
    }
}
