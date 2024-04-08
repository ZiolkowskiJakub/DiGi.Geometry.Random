using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static Vector2D Vector2D(int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            Vector2D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector2D(DiGi.Core.Query.Random(new Range<double>(0, 1), seed, tolerance), DiGi.Core.Query.Random(new Range<double>(0, 1), seed, tolerance));
                length = result.Length;
            }

            return result.Unit;
        }

        public static Vector2D Vector2D(BoundingBox2D boundingBox2D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            Point2D min = boundingBox2D.Min;
            if (min == null)
            {
                return null;
            }

            Point2D max = boundingBox2D.Max;
            if (max == null)
            {
                return null;
            }

            return Vector2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), seed, tolerance);
        }

        public static Vector2D Vector2D(Range<double> x, Range<double> y, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            Vector2D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector2D(DiGi.Core.Query.Random(x, seed, tolerance), DiGi.Core.Query.Random(y, seed, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}
