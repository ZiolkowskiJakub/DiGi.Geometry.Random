using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static Polygon2D Polygon2D(BoundingBox2D boundingBox2D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null || pointCount < 3)
            {
                return null;
            }

            List<Point2D> point2Ds = boundingBox2D.GetPoints();
            if(point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return Polygon2D(new Polygon2D(point2Ds), pointCount, seed, tolerance);
        }

        public static Polygon2D Polygon2D(BoundingBox2D boundingBox2D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null || pointCount < 3 || random == null)
            {
                return null;
            }

            List<Point2D> point2Ds = boundingBox2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return Polygon2D(new Polygon2D(point2Ds), pointCount, random, tolerance);
        }

        public static Polygon2D Polygon2D(Range<double> x, Range<double> y, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if(x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon2D(x, y, pointCount, random, tolerance);
        }

        public static Polygon2D Polygon2D(Range<double> x, Range<double> y, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            return Polygon2D(new BoundingBox2D(x, y), pointCount, random, tolerance);
        }

        public static Polygon2D Polygon2D(Range<double> x, Range<double> y, Range<int> pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon2D(x, y, pointCount, random, tolerance);
        }

        public static Polygon2D Polygon2D(Range<double> x, Range<double> y, Range<int> pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            int pointCount_Temp = DiGi.Core.Query.Random(random, pointCount);

            return Polygon2D(new BoundingBox2D(x, y), pointCount_Temp, random, tolerance);
        }

        public static Polygon2D Polygon2D(IPolygonal2D polygonal2D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || pointCount < 3)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon2D(polygonal2D, pointCount, random, tolerance);

        }

        public static Polygon2D Polygon2D(IPolygonal2D polygonal2D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || pointCount < 3 || random == null)
            {
                return null;
            }

            VolatileBoundable2D<ISegmentable2D> volatileBoundable2D = new VolatileBoundable2D<ISegmentable2D>(polygonal2D);

            List<Point2D> point2Ds = new List<Point2D>() { Point2D(polygonal2D, random, tolerance) };
            while (point2Ds.Count < pointCount)
            {
                Point2D point2D = Point2D(polygonal2D, random, tolerance);
                if (point2D == null)
                {
                    continue;
                }

                Point2D point2D_Temp = null;

                point2D_Temp = point2D.ClosestPoint(point2Ds, out double distance);
                if (point2D_Temp == null || distance < tolerance)
                {
                    continue;
                }

                int index = point2Ds.IndexOf(point2D_Temp);

                int nextIndex = DiGi.Core.Query.Next(point2Ds.Count, index);
                Point2D point2D_Next = point2Ds[nextIndex];
                Segment2D segment2D_Next = new Segment2D(point2D, point2D_Next);

                if(Query.Intersect(volatileBoundable2D, segment2D_Next, tolerance))
                {
                    continue;
                }

                int previousIndex = DiGi.Core.Query.Previous(point2Ds.Count, index);
                Point2D point2D_Previous = point2Ds[nextIndex];
                Segment2D segment2D_Previous = new Segment2D(point2D, point2D_Previous);

                if (Query.Intersect(volatileBoundable2D, segment2D_Previous, tolerance))
                {
                    continue;
                }

                if(point2Ds.Count < 3)
                {
                    point2Ds.Insert(index, point2D);
                    continue;
                }

                List<Point2D> point2Ds_Temp = new List<Point2D>(point2Ds);
                point2Ds_Temp.Insert(index, point2D);

                Polygon2D polygon2D_Temp = new Polygon2D(point2Ds_Temp);

                if (polygon2D_Temp.SelfIntersect(tolerance))
                {
                    continue;
                }

                point2Ds = point2Ds_Temp;
            }

            return new Polygon2D(point2Ds);
        }

        public static Polygon2D Polygon2D(IPolygonal2D polygonal2D, Range<int> pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || pointCount == null || random == null)
            {
                return null;
            }

            int pointCount_Temp = DiGi.Core.Query.Random(random, pointCount);

            return Polygon2D(polygonal2D, pointCount_Temp, random, tolerance);
        }
    }
}
