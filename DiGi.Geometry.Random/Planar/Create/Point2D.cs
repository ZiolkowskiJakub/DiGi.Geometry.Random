using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static Point2D Point2D(BoundingBox2D boundingBox2D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
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

            return Point2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), seed, tolerance);
        }

        public static Point2D Point2D(Range<double> x, Range<double> y, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            List<int> seeds = DiGi.Core.Query.Seeds(2, seed);

            return new Point2D(DiGi.Core.Query.Random(x, seeds[0], tolerance), DiGi.Core.Query.Random(y, seeds[1], tolerance));

        }

        public static Point2D Point2D(IPolygonal2D polygonal2D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            BoundingBox2D boundingBox2D = polygonal2D?.GetBoundingBox();
            if(boundingBox2D == null)
            {
                return null;
            }

            List<int> seeds = DiGi.Core.Query.Seeds(2, seed);

            double x = DiGi.Core.Query.Random(boundingBox2D.Min.X, boundingBox2D.Max.X, seeds[0], tolerance);

            Line2D line2D = new Line2D(new Point2D(x, 0), Constans.Vector2D.WorldY);

            IntersectionResult2D intersectionResult2D = Planar.Create.IntersectionResult2D(polygonal2D, line2D, tolerance);
            if(intersectionResult2D == null || !intersectionResult2D.Intersect)
            {
                return null;
            }

            List<IGeometry2D> geometry2Ds = intersectionResult2D.GetGeometry2Ds<IGeometry2D>();

            Point2D point2D_1 = null;
            Point2D point2D_2 = null;
            foreach(IGeometry2D geometry2D in geometry2Ds)
            {
                if(geometry2D is Point2D)
                {
                    if(point2D_1 == null)
                    {
                        point2D_1 = (Point2D)geometry2D;
                    }
                    else
                    {
                        point2D_2 = (Point2D)geometry2D;
                    }
                }
                else if(geometry2D is Segment2D)
                {
                    point2D_1 = ((Segment2D)geometry2D)[0];
                    point2D_2 = ((Segment2D)geometry2D)[1];
                }

                if (point2D_1 != null && point2D_2 != null)
                {
                    break;
                }
            }

            if(point2D_1 == null && point2D_2 == null)
            {
                return null;
            }

            if(point2D_1 == null)
            {
                return point2D_2;
            }

            if(point2D_2 == null)
            {
                return point2D_1;
            }
            
            double y = DiGi.Core.Query.Random(point2D_1.Y, point2D_2.Y, seeds[1], tolerance);

            return new Point2D(x, y);
        }
    }
}
