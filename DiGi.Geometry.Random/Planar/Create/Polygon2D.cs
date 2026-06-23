using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Polygon2D"/> based on the provided <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> used to derive the polygon vertices.</param>
        /// <param name="pointCount">The number of points to be included in the resulting <see cref="Classes.Polygon2D"/>.</param>
        /// <param name="seed">An optional integer seed for random point generation. Defaults to -1.</param>
        /// <param name="tolerance">The double value representing the distance tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> instance if the <see cref="BoundingBox2D"/> is valid and contains at least three points; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(BoundingBox2D? boundingBox2D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null || pointCount < 3)
            {
                return null;
            }

            List<Point2D>? point2Ds = boundingBox2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return Polygon2D(new Polygon2D(point2Ds), pointCount, seed, tolerance);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon2D"/> based on the provided axis-aligned bounding box, point count, and random number generator.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> used to derive the initial points for the polygon.</param>
        /// <param name="pointCount">The integer number of points required for the resulting polygon.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used for randomization during polygon generation.</param>
        /// <param name="tolerance">The double value specifying the distance tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> if the <paramref name="boundingBox2D"/> and <paramref name="random"/> are not null and the <paramref name="pointCount"/> is at least 3; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(BoundingBox2D? boundingBox2D, int pointCount, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null || pointCount < 3 || random == null)
            {
                return null;
            }

            List<Point2D>? point2Ds = boundingBox2D.GetPoints();
            if (point2Ds == null || point2Ds.Count < 3)
            {
                return null;
            }

            return Polygon2D(new Polygon2D(point2Ds), pointCount, random, tolerance);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon2D"/> based on the specified X and Y ranges, point count, seed, and tolerance.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> for the X-axis coordinates.</param>
        /// <param name="y">The <see cref="Range{T}"/> for the Y-axis coordinates.</param>
        /// <param name="pointCount">The integer number of points to generate for the polygon.</param>
        /// <param name="seed">The integer seed used for random point generation; a value of -1 uses a default random seed.</param>
        /// <param name="tolerance">The double precision tolerance for geometric operations, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> if both the X and Y ranges are provided; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(Range<double>? x, Range<double>? y, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon2D(x, y, pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a <see cref="Classes.Polygon2D"/> based on the specified X and Y ranges, point count, random number generator, and tolerance.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> defining the extent of the polygon along the X-axis.</param>
        /// <param name="y">The <see cref="Range{T}"/> defining the extent of the polygon along the Y-axis.</param>
        /// <param name="pointCount">The integer number of points to generate for the <see cref="Classes.Polygon2D"/>.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random coordinates.</param>
        /// <param name="tolerance">The double value representing the geometric tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> if the X range, Y range, and random generator are provided; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(Range<double>? x, Range<double>? y, int pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            return Polygon2D(new BoundingBox2D(x, y), pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a <see cref="Classes.Polygon2D"/> based on specified coordinate and point count ranges.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> of double values defining the X-axis boundaries.</param>
        /// <param name="y">The <see cref="Range{T}"/> of double values defining the Y-axis boundaries.</param>
        /// <param name="pointCount">The <see cref="Range{T}"/> of integer values defining the possible number of vertices in the polygon.</param>
        /// <param name="seed">An integer seed used to initialize the random number generator. A value of -1 indicates a non-deterministic seed.</param>
        /// <param name="tolerance">A double value representing the macro distance tolerance for geometric operations.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> instance if both X and Y ranges are provided; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(Range<double>? x, Range<double>? y, Range<int>? pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon2D(x, y, pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Polygon2D"/> within the specified X and Y ranges, with a number of points determined by the provided point count range.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> defining the boundaries for the X-axis.</param>
        /// <param name="y">The <see cref="Range{T}"/> defining the boundaries for the Y-axis.</param>
        /// <param name="pointCount">The <see cref="Range{T}"/> used to randomly determine the number of vertices in the polygon.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used for random generation.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A randomly generated <see cref="Classes.Polygon2D"/> if both the X and Y ranges are provided; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(Range<double>? x, Range<double>? y, Range<int>? pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            int pointCount_Temp = DiGi.Core.Query.Random(random, pointCount);

            return Polygon2D(new BoundingBox2D(x, y), pointCount_Temp, random, tolerance);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polygon2D"/> from the specified <see cref="IPolygonal2D"/> source using a defined number of points and an optional random seed.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> source geometry used to generate the polygon.</param>
        /// <param name="pointCount">The integer number of points to be included in the resulting <see cref="Classes.Polygon2D"/>.</param>
        /// <param name="seed">The integer seed used for random point generation. A value of -1 indicates a non-deterministic seed.</param>
        /// <param name="tolerance">The double precision tolerance used for geometric operations, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> instance if the <paramref name="polygonal2D"/> is not null and the <paramref name="pointCount"/> is 3 or greater; otherwise, null.</returns>
        public static Polygon2D? Polygon2D(IPolygonal2D? polygonal2D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || pointCount < 3)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon2D(polygonal2D, pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Polygon2D"/> with a specified number of vertices based on the provided <see cref="IPolygonal2D"/> geometry, ensuring that the resulting polygon does not self-intersect and its segments do not intersect the source geometry.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object used as the basis for sampling random points.</param>
        /// <param name="pointCount">The desired number of vertices (<see cref="int"/>) for the generated polygon; must be at least 3.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random point coordinates.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance used for proximity and intersection calculations, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> instance containing the generated vertices if successful; otherwise, <see langword="null"/> if the inputs are invalid or a valid polygon cannot be constructed.</returns>
        public static Polygon2D? Polygon2D(IPolygonal2D? polygonal2D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || pointCount < 3 || random == null)
            {
                return null;
            }

            if (Point2D(polygonal2D, random, tolerance) is not Point2D point2D_First)
            {
                return null;
            }

            List<Point2D> point2Ds = [point2D_First];
            while (point2Ds.Count < pointCount)
            {
                Point2D? point2D = Point2D(polygonal2D, random, tolerance);
                if (point2D == null)
                {
                    continue;
                }

                Point2D? point2D_Temp = point2D.ClosestPoint(point2Ds, out double distance);
                if (point2D_Temp == null || distance < tolerance)
                {
                    continue;
                }

                int index = point2Ds.IndexOf(point2D_Temp);

                int nextIndex = DiGi.Core.Query.Next(point2Ds.Count, index);
                Point2D point2D_Next = point2Ds[nextIndex];
                Segment2D segment2D_Next = new(point2D, point2D_Next);

                if (Query.Intersect(polygonal2D, segment2D_Next, tolerance))
                {
                    continue;
                }

                DiGi.Core.Query.Previous(point2Ds.Count, index);
                Point2D point2D_Previous = point2Ds[nextIndex];
                Segment2D segment2D_Previous = new(point2D, point2D_Previous);

                if (Query.Intersect(polygonal2D, segment2D_Previous, tolerance))
                {
                    continue;
                }

                if (point2Ds.Count < 3)
                {
                    point2Ds.Insert(index, point2D);
                    continue;
                }

                List<Point2D> point2Ds_Temp = [.. point2Ds];
                point2Ds_Temp.Insert(index, point2D);

                Polygon2D polygon2D_Temp = new(point2Ds_Temp);

                if (polygon2D_Temp.SelfIntersect(tolerance))
                {
                    continue;
                }

                point2Ds = point2Ds_Temp;
            }

            return new Polygon2D(point2Ds);
        }

        /// <summary>
        /// Generates a <see cref="Classes.Polygon2D"/> from an <see cref="IPolygonal2D"/> source using a randomly determined number of points.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object to be converted into a polygon.</param>
        /// <param name="pointCount">A nullable <see cref="int"/> used as the basis for determining the random number of points.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate the random point count.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value for geometric operations, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Polygon2D"/> instance if the operation is successful; otherwise, <c>null</c> if <paramref name="polygonal2D"/>, <paramref name="pointCount"/>, or <paramref name="random"/> is <c>null</c>.</returns>
        public static Polygon2D? Polygon2D(IPolygonal2D? polygonal2D, Range<int>? pointCount, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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