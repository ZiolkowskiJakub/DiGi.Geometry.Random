using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static List<Point2D>? Point2Ds(BoundingBox2D? boundingBox2D, int count, int seed = -1)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(boundingBox2D, count, random);
        }

        public static List<Point2D>? Point2Ds(BoundingBox2D? boundingBox2D, int count, System.Random? random)
        {
            if (boundingBox2D == null || random == null)
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

            List<Point2D>? result = [];
            for (int i = 0; i < count; i++)
            {
                Point2D? point2D = Point2D(boundingBox2D, random);
                if (point2D is null)
                {
                    continue;
                }

                result.Add(point2D);
            }

            return result;
        }

        public static List<Point2D>? Point2Ds(Range<double>? x, Range<double>? y, int count, int seed = -1)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(x, y, count, random);
        }

        public static List<Point2D>? Point2Ds(Range<double>? x, Range<double>? y, int count, System.Random random)
        {
            if (x == null || y == null)
            {
                return null;
            }

            List<Point2D> result = [];
            for (int i = 0; i < count; i++)
            {
                Point2D? point2D = Point2D(x, y, random);
                if (point2D is null)
                {
                    continue;
                }

                result.Add(point2D);
            }

            return result;
        }

        public static List<Point2D>? Point2Ds(BoundingBox2D? boundingBox2D, Range<int>? count, int seed = -1)
        {
            if (boundingBox2D == null || count == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(boundingBox2D, count, random);
        }

        public static List<Point2D>? Point2Ds(BoundingBox2D? boundingBox2D, Range<int>? count, System.Random random)
        {
            if (boundingBox2D == null || count == null || random == null)
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

            int count_Temp = DiGi.Core.Query.Random(random, count);

            List<Point2D> result = [];
            for (int i = 0; i < count_Temp; i++)
            {
                Point2D? point2D = Point2D(boundingBox2D, random);
                if (point2D is null)
                {
                    continue;
                }

                result.Add(point2D);
            }

            return result;
        }

        public static List<Point2D>? Point2Ds(IPolygonal2D? polygonal2D, int count, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(polygonal2D, count, random, tolerance);
        }

        public static List<Point2D>? Point2Ds(IPolygonal2D? polygonal2D, int count, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || random == null)
            {
                return null;
            }

            List<Point2D> result = [];
            for (int i = 0; i < count; i++)
            {
                Point2D? point2D = Point2D(polygonal2D, random, tolerance);
                if (point2D is null)
                {
                    continue;
                }

                result.Add(point2D);
            }

            return result;
        }

        public static List<Point2D>? Point2Ds(IPolygonal2D? polygonal2D, Range<int>? count, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || count == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(polygonal2D, count, random, tolerance);
        }

        public static List<Point2D>? Point2Ds(IPolygonal2D? polygonal2D, Range<int>? count, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || count == null || random == null)
            {
                return null;
            }

            int count_Temp = DiGi.Core.Query.Random(random, count);

            List<Point2D> result = [];
            for (int i = 0; i < count_Temp; i++)
            {
                Point2D? point2D = Point2D(polygonal2D, random, tolerance);
                if (point2D is null)
                {
                    continue;
                }

                result.Add(point2D);
            }

            return result;
        }
    }
}