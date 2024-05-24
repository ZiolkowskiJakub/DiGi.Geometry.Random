using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

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

            return Segment2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), seed, tolerance);
        }

        public static Segment2D Segment2D(Range<double> x, Range<double> y, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            Segment2D result = null;

            List<int> seeds = DiGi.Core.Query.Seeds(2, seed);

            double length = 0;
            while (length < tolerance)
            {
                result = new Segment2D(Point2D(x, y, seeds[0], tolerance), Point2D(x, y, seeds[1], tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}
