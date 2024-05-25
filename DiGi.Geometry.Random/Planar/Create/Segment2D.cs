using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static Segment2D Segment2D(BoundingBox2D boundingBox2D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Segment2D(boundingBox2D, random, tolerance);
        }

        public static Segment2D Segment2D(BoundingBox2D boundingBox2D, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null || random == null)
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

            return Segment2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), random, tolerance);
        }

        public static Segment2D Segment2D(Range<double> x, Range<double> y, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Segment2D(x, y, random, tolerance);
        }

        public static Segment2D Segment2D(Range<double> x, Range<double> y, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            Segment2D result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Segment2D(Point2D(x, y, random, tolerance), Point2D(x, y, random, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}
