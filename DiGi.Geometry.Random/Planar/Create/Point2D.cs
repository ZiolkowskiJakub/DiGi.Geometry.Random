using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static Point2D? Point2D(BoundingBox2D? boundingBox2D, int seed = -1)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            Point2D? min = boundingBox2D.Min;
            if (min == null)
            {
                return null;
            }

            Point2D? max = boundingBox2D.Max;
            if (max == null)
            {
                return null;
            }

            return Point2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), seed);
        }

        public static Point2D? Point2D(BoundingBox2D? boundingBox2D, System.Random? random)
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

            return Point2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), random);
        }

        public static Point2D? Point2D(Range<double>? x, Range<double>? y, int seed = -1)
        {
            if (x == null || y == null)
            {
                return null;
            }

            return Point2D(x, y, DiGi.Core.Create.Random(seed));
        }

        public static Point2D? Point2D(Range<double>? x, Range<double>? y, System.Random? random)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            return new Point2D(DiGi.Core.Query.Random(random, x), DiGi.Core.Query.Random(random, y));
        }

        public static Point2D? Point2D(IPolygonal2D? polygonal2D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2D(polygonal2D, random, tolerance);
        }

        public static Point2D? Point2D(IPolygonal2D? polygonal2D, System.Random? random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || random == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = polygonal2D.GetBoundingBox();
            if (boundingBox2D == null)
            {
                return null;
            }

            double x = DiGi.Core.Query.Random(random, boundingBox2D.Min.X, boundingBox2D.Max.X, tolerance);

            Line2D line2D = new(new Point2D(x, 0), Constans.Vector2D.WorldY);

            IntersectionResult2D? intersectionResult2D = Planar.Create.IntersectionResult2D(polygonal2D, line2D, tolerance);
            if (intersectionResult2D == null || !intersectionResult2D.Intersect)
            {
                return null;
            }

            List<IGeometry2D>? geometry2Ds = intersectionResult2D.GetGeometry2Ds<IGeometry2D>();
            if (geometry2Ds is null)
            {
                return null;
            }

            Point2D? point2D_1 = null;
            Point2D? point2D_2 = null;
            foreach (IGeometry2D geometry2D in geometry2Ds)
            {
                if (geometry2D is Point2D point2D_Temp)
                {
                    if (point2D_1 == null)
                    {
                        point2D_1 = point2D_Temp;
                    }
                    else
                    {
                        point2D_2 = point2D_Temp;
                    }
                }
                else if (geometry2D is Segment2D segment2D)
                {
                    point2D_1 = segment2D[0];
                    point2D_2 = segment2D[1];
                }

                if (point2D_1 != null && point2D_2 != null)
                {
                    break;
                }
            }

            if (point2D_1 == null && point2D_2 == null)
            {
                return null;
            }

            if (point2D_1 == null)
            {
                return point2D_2;
            }

            if (point2D_2 == null)
            {
                return point2D_1;
            }

            double y = DiGi.Core.Query.Random(random, point2D_1.Y, point2D_2.Y, tolerance);

            return new Point2D(x, y);
        }

        public static Point2D? Point2D(Segment2D? segment2D, System.Random? random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (segment2D == null || random == null)
            {
                return null;
            }

            if (segment2D[0] is not Point2D point2D_1)
            {
                return null;
            }

            if (segment2D[1] is not Point2D point2D_2)
            {
                return null;
            }

            Range<double> range = new(point2D_1.X, point2D_2.X);

            double x = DiGi.Core.Query.Random(random, range, tolerance);

            if (range.Length < tolerance)
            {
                range = new Range<double>(point2D_1.Y, point2D_2.Y);
                if (range.Length < tolerance)
                {
                    return null;
                }

                double y = DiGi.Core.Query.Random(random, range, tolerance);

                return segment2D.ClosestPoint(new Point2D(x, y));
            }

            LinearEquation? linearEquation = segment2D.LinearEquation();
            if (linearEquation is null)
            {
                return null;
            }

            return segment2D.ClosestPoint(new Point2D(x, linearEquation.Evaluate(x)));
        }

        public static Point2D? Point2D(PolygonalFace2D? polygonalFace2D, System.Random? random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygonalFace2D == null || random == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = polygonalFace2D.GetBoundingBox();
            if (boundingBox2D is null || boundingBox2D.Width < tolerance)
            {
                return null;
            }

            if (boundingBox2D.Height < tolerance)
            {
                return null;
            }

            List<IPolygonal2D>? internalEdges = polygonalFace2D.InternalEdges;
            if (internalEdges == null || internalEdges.Count == 0)
            {
                return Point2D(polygonalFace2D.ExternalEdge, random, tolerance);
            }

            Range<double> range_Y = new(boundingBox2D.Min.Y, boundingBox2D.Max.Y);

            Point2D? result;
            do
            {
                result = null;

                double y = DiGi.Core.Query.Random(random, range_Y, tolerance);
                if (!double.IsNaN(y))
                {
                    IntersectionResult2D? intersectionResult2D = Planar.Create.IntersectionResult2D(polygonalFace2D, new Line2D(new Point2D(0, y), Constans.Vector2D.WorldX), tolerance);
                    if (intersectionResult2D != null && intersectionResult2D.Intersect)
                    {
                    }
                }
            }
            while (result == null || !polygonalFace2D.Inside(result, tolerance));

            return result;
        }
    }
}