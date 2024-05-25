using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static Vector3D Vector3D(int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector3D(random, tolerance);
        }

        public static Vector3D Vector3D(System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if(random == null)
            {
                return null;
            }

            Vector3D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector3D(DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance), DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance), DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance));
                length = result.Length;
            }

            return result.Unit;
        }

        public static Vector3D Vector2D(BoundingBox3D boundingBox3D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector3D(boundingBox3D, random, tolerance);
        }

        public static Vector3D Vector3D(BoundingBox3D boundingBox3D, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
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

            return Vector3D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), new Range<double>(min.Z, max.Z), random, tolerance);
        }

        public static Vector3D Vector3D(Range<double> x, Range<double> y, Range<double> z, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector3D(x, y, z, random, tolerance);
        }

        public static Vector3D Vector3D(Range<double> x, Range<double> y, Range<double> z, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            Vector3D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector3D(DiGi.Core.Query.Random(random, x, tolerance), DiGi.Core.Query.Random(random, y, tolerance), DiGi.Core.Query.Random(random, z, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}
