using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static Vector2D Vector2D(int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector2D(random, tolerance);
        }

        public static Vector2D Vector2D(System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if(random == null)
            {
                return null;
            }

            Vector2D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector2D(DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance), DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance));
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

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector2D(boundingBox2D, random, tolerance);
        }

        public static Vector2D Vector2D(BoundingBox2D boundingBox2D, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
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

            return Vector2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), random, tolerance);
        }

        public static Vector2D Vector2D(Range<double> x, Range<double> y, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector2D(x, y, random, tolerance);

        }

        public static Vector2D Vector2D(Range<double> x, Range<double> y, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            Vector2D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector2D(DiGi.Core.Query.Random(random, x, tolerance), DiGi.Core.Query.Random(random, y, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}
