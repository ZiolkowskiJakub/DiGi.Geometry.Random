using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static Vector3D Vector3D(int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            Vector3D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector3D(DiGi.Core.Query.Random(new Range<double>(0, 1), seed, tolerance), DiGi.Core.Query.Random(new Range<double>(0, 1), seed, tolerance), DiGi.Core.Query.Random(new Range<double>(0, 1), seed, tolerance));
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

            return Vector3D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), new Range<double>(min.Z, max.Z), seed, tolerance);
        }

        public static Vector3D Vector3D(Range<double> x, Range<double> y, Range<double> z, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            Vector3D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector3D(DiGi.Core.Query.Random(x, seed, tolerance), DiGi.Core.Query.Random(y, seed, tolerance), DiGi.Core.Query.Random(z, seed, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}
