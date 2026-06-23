using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a collection of random points within the specified axis-aligned bounding box.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D" /> defining the area from which to generate points.</param>
        /// <param name="count">The number of <see cref="Classes.Point2D" /> instances to create.</param>
        /// <param name="seed">The seed value used for the random number generator to ensure reproducibility.</param>
        /// <returns>An array of <see cref="Classes.Point2D" /> objects contained within the <paramref name="boundingBox2D" />, or <see langword="null" /> if <paramref name="boundingBox2D" /> is null.</returns>
        public static List<Point2D>? Point2Ds(BoundingBox2D? boundingBox2D, int count, int seed = -1)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(boundingBox2D, count, random);
        }

        /// <summary>
        /// Generates a list of random <see cref="Classes.Point2D"/> instances within the specified <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> that defines the boundaries for generating points.</param>
        /// <param name="count">The number of random points to generate.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to produce the random values.</param>
        /// <returns>A <see cref="List{Point2D}"/> containing the generated <see cref="Classes.Point2D"/> instances, or <c>null</c> if the <paramref name="boundingBox2D"/> is null, the <paramref name="random"/> instance is null, or the bounding box corners are not defined.</returns>
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

        /// <summary>
        /// Generates a list of random <see cref="Classes.Point2D"/> instances within the specified X and Y ranges.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> defining the bounds for the X coordinates.</param>
        /// <param name="y">The <see cref="Range{T}"/> defining the bounds for the Y coordinates.</param>
        /// <param name="count">The number of <see cref="Classes.Point2D"/> instances to generate.</param>
        /// <param name="seed">The seed value used to initialize the random number generator.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or <see langword="null"/> if either <paramref name="x" /> or <paramref name="y" /> is null.</returns>
        public static List<Point2D>? Point2Ds(Range<double>? x, Range<double>? y, int count, int seed = -1)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(x, y, count, random);
        }

        /// <summary>
        /// Generates a collection of <see cref="Classes.Point2D"/> objects within the specified X and Y ranges.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> defining the range for the X coordinates.</param>
        /// <param name="y">The <see cref="Range{T}"/> defining the range for the Y coordinates.</param>
        /// <param name="count">The number of points to attempt to generate.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random values.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or null if either the <paramref name="x"/> or <paramref name="y"/> range is null.</returns>
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

        /// <summary>
        /// Generates a list of random <see cref="Classes.Point2D"/> instances within the specified <see cref="BoundingBox2D"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> that defines the boundaries for generating the points.</param>
        /// <param name="count">The <see cref="Range{T}"/> of integers specifying the number of points to generate.</param>
        /// <param name="seed">The seed value used to initialize the random number generator.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or <see langword="null"/> if <paramref name="boundingBox2D"/> or <paramref name="count"/> is null.</returns>
        public static List<Point2D>? Point2Ds(BoundingBox2D? boundingBox2D, Range<int>? count, int seed = -1)
        {
            if (boundingBox2D == null || count == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(boundingBox2D, count, random);
        }

        /// <summary>
        /// Generates a list of random <see cref="Classes.Point2D"/> instances within the specified <see cref="BoundingBox2D"/> based on a quantity randomly selected from the provided <see cref="Range{T}"/>.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D"/> that defines the spatial boundaries for generating points.</param>
        /// <param name="count">The <see cref="Range{T}"/> of integers used to determine a random number of points to generate.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used for random number generation.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or <see langword="null"/> if <paramref name="boundingBox2D"/>, <paramref name="count"/>, or <paramref name="random"/> is null, or if the bounding box lacks a minimum or maximum corner.</returns>
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

        /// <summary>
        /// Generates a collection of random <see cref="Classes.Point2D"/> instances within the specified polygonal area.
        /// </summary>
        /// <param name="polygonal2D">The polygonal object used as the boundary for generating points.</param>
        /// <param name="count">The number of <see cref="Classes.Point2D"/> instances to generate.</param>
        /// <param name="seed">The seed value for the random number generator; a value of -1 indicates that a random seed should be used.</param>
        /// <param name="tolerance">The distance tolerance applied during point generation, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or <c>null</c> if the <paramref name="polygonal2D"/> is <c>null</c>.</returns>
        public static List<Point2D>? Point2Ds(IPolygonal2D? polygonal2D, int count, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(polygonal2D, count, random, tolerance);
        }

        /// <summary>
        /// Generates a list of random <see cref="Classes.Point2D" /> instances based on the provided <see cref="IPolygonal2D" /> object.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D" /> instance used to generate points.</param>
        /// <param name="count">The number of <see cref="Classes.Point2D" /> instances to attempt to create.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used for random generation.</param>
        /// <param name="tolerance">The distance tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="List{T}" /> containing the successfully generated points; otherwise, <c>null</c> if <paramref name="polygonal2D" /> or <paramref name="random" /> is <c>null</c>.</returns>
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

        /// <summary>
        /// Generates a list of <see cref="Classes.Point2D"/> objects from the specified <see cref="IPolygonal2D"/> instance based on a count range and randomization seed.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> object used to generate points.</param>
        /// <param name="count">The <see cref="Range{T}"/> of <see cref="int"/> values specifying the number of points to be generated.</param>
        /// <param name="seed">An <see cref="int"/> value used as the seed for the random number generator. Defaults to -1.</param>
        /// <param name="tolerance">A <see cref="double"/> value representing the distance tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or <see langword="null"/> if <paramref name="polygonal2D"/> or <paramref name="count"/> is <see langword="null"/>.</returns>
        public static List<Point2D>? Point2Ds(IPolygonal2D? polygonal2D, Range<int>? count, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null || count == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2Ds(polygonal2D, count, random, tolerance);
        }

        /// <summary>
        /// Generates a list of random <see cref="Classes.Point2D"/> instances from the specified polygonal object based on a random count within a given range.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D"/> instance used as the source for point generation.</param>
        /// <param name="count">The <see cref="Range{T}"/> of integers from which the number of points to generate is randomly selected.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to perform random sampling.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value for point generation, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="List{T}"/> containing the generated points, or <see langword="null"/> if <paramref name="polygonal2D"/>, <paramref name="count"/>, or <paramref name="random"/> is null.</returns>
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