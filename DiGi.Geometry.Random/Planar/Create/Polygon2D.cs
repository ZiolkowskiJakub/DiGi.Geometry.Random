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

            Func<Polygon2D, Segment2D, bool> func = new Func<Polygon2D, Segment2D, bool>((x, y) =>
            {
                if (x == null || y == null)
                {
                    return false;
                }

                IntersectionResult2D intersectionResult2D = Planar.Create.IntersectionResult2D(x, y, tolerance);
                if (intersectionResult2D == null || !intersectionResult2D.Intersect)
                {
                    return true;
                }

                List<IGeometry2D> geometry2Ds = intersectionResult2D.GetGeometry2Ds<IGeometry2D>();
                for (int i = geometry2Ds.Count - 1; i >= 0; i--)
                {
                    if (geometry2Ds[i] is Point2D)
                    {
                        Point2D point2D = (Point2D)geometry2Ds[i];
                        if (point2D.AlmostEquals(y[0], tolerance) || point2D.AlmostEquals(y[1], tolerance))
                        {
                            geometry2Ds.RemoveAt(i);
                            continue;
                        }
                    }
                }

                return geometry2Ds != null && geometry2Ds.Count > 0;
            });

            List<Point2D> point2Ds = Point2Ds(polygonal2D, 3, random, tolerance);
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

                Polygon2D polygon2D_Temp = new Polygon2D(point2Ds);

                bool intersect;

                intersect = func.Invoke(polygon2D_Temp, new Segment2D(point2D, point2D_Temp));
                if (intersect)
                {
                    continue;
                }

                int index = point2Ds.IndexOf(point2D_Temp);

                int nextIndex = DiGi.Core.Query.Next(point2Ds.Count, index);

                point2D_Temp = point2Ds[nextIndex];

                intersect = func.Invoke(polygon2D_Temp, new Segment2D(point2D, point2D_Temp));
                if (!intersect)
                {
                    point2Ds.Insert(nextIndex, point2D);
                    continue;
                }

                int previousIndex = DiGi.Core.Query.Previous(point2Ds.Count, index);

                point2D_Temp = point2Ds[previousIndex];

                intersect = func.Invoke(polygon2D_Temp, new Segment2D(point2D, point2D_Temp));
                if (intersect)
                {
                    continue;
                }

                point2Ds.Insert(index, point2D);
            }

            return new Polygon2D(point2Ds);
        }

    }
}
