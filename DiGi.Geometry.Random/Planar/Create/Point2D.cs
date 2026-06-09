using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Math.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> within the specified <see cref="BoundingBox2D" />.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D" /> that defines the boundaries for the point generation.</param>
        /// <param name="seed">An <see cref="int" /> used as a seed for the random number generator to ensure reproducibility.</param>
        /// <returns>A <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> located within the <paramref name="boundingBox2D" />, or <see langword="null" /> if the <paramref name="boundingBox2D" /> or its minimum and maximum corners are null.</returns>
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

        /// <summary>
        /// Generates a random <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> within the boundaries of the specified <see cref="BoundingBox2D" />.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="BoundingBox2D" /> that defines the area from which to generate the point.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate the random coordinates.</param>
        /// <returns>A <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> located within the <paramref name="boundingBox2D" />, or <c>null</c> if <paramref name="boundingBox2D" /> is <c>null</c>, <paramref name="random" /> is <c>null</c>, or if the bounding box's minimum or maximum corners are not defined.</returns>
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

        /// <summary>
        /// Generates a random <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> within the specified X and Y coordinate ranges.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the range for the X coordinate.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the range for the Y coordinate.</param>
        /// <param name="seed">The integer seed used to initialize the random number generator. Defaults to -1.</param>
        /// <returns>A <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> if both <paramref name="x" /> and <paramref name="y" /> are not null; otherwise, null.</returns>
        public static Point2D? Point2D(Range<double>? x, Range<double>? y, int seed = -1)
        {
            if (x == null || y == null)
            {
                return null;
            }

            return Point2D(x, y, DiGi.Core.Create.Random(seed));
        }

        /// <summary>
        /// Generates a random <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> within the specified X and Y ranges using the provided <see cref="System.Random" /> instance.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}" /> of <see cref="double" /> values defining the range for the X coordinate.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}" /> of <see cref="double" /> values defining the range for the Y coordinate.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random numbers within the specified ranges.</param>
        /// <returns>A new <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> if <paramref name="x" />, <paramref name="y" />, and <paramref name="random" /> are not null; otherwise, <see langword="null" />.</returns>
        public static Point2D? Point2D(Range<double>? x, Range<double>? y, System.Random? random)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            return new Point2D(DiGi.Core.Query.Random(random, x), DiGi.Core.Query.Random(random, y));
        }

        /// <summary>
        /// Generates a <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> from the specified <see cref="IPolygonal2D" /> object.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D" /> instance to process. This parameter can be null.</param>
        /// <param name="seed">An <see cref="int" /> value used as the seed for the random number generator.</param>
        /// <param name="tolerance">A <see cref="double" /> representing the distance tolerance, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="DiGi.Geometry.Planar.Classes.Point2D" /> instance if <paramref name="polygonal2D" /> is not null; otherwise, null.</returns>
        public static Point2D? Point2D(IPolygonal2D? polygonal2D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point2D(polygonal2D, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Point2D" /> within the bounds of the specified <see cref="IPolygonal2D" /> geometry.
        /// </summary>
        /// <param name="polygonal2D">The <see cref="IPolygonal2D" /> geometry used as the sampling area.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random coordinates.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value for geometric operations, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly sampled <see cref="T:DiGi.Geometry.Planar.Classes.Point2D" /> if a point could be determined; otherwise, <c>null</c>.</returns>
        public static Point2D? Point2D(IPolygonal2D? polygonal2D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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

            Line2D line2D = new(new Point2D(x, 0), Constants.Vector2D.WorldY);

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

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Point2D" /> located on the specified <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" />.
        /// </summary>
        /// <param name="segment2D">The <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" /> from which to sample a random point.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate the random coordinates.</param>
        /// <param name="tolerance">The <see cref="double" /> distance tolerance used to determine if the segment is vertical or horizontal, defaulting to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly sampled <see cref="T:DiGi.Geometry.Planar.Classes.Point2D" /> on the <paramref name="segment2D" />, or <see langword="null" /> if the <paramref name="segment2D" /> is null, the <paramref name="random" /> instance is null, or the segment length is smaller than the specified <paramref name="tolerance" />.</returns>
        public static Point2D? Point2D(Segment2D? segment2D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Point2D" /> located within the boundaries of the specified <see cref="T:DiGi.Geometry.Planar.Classes.PolygonalFace2D" />.
        /// </summary>
        /// <param name="polygonalFace2D">The <see cref="T:DiGi.Geometry.Planar.Classes.PolygonalFace2D" /> from which to sample a random point.</param>
        /// <param name="random">The <see cref="T:System.Random" /> instance used to generate the random coordinates.</param>
        /// <param name="tolerance">The <see cref="T:System.Double" /> tolerance value used for geometric validation and intersection tests.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Planar.Classes.Point2D" /> that is inside the <paramref name="polygonalFace2D" />, or <see langword="null" /> if the <paramref name="polygonalFace2D" /> or <paramref name="random" /> are null, or if the face's bounding box dimensions are smaller than the specified <paramref name="tolerance" />.</returns>
        public static Point2D? Point2D(PolygonalFace2D? polygonalFace2D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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
                    IntersectionResult2D? intersectionResult2D = Planar.Create.IntersectionResult2D(polygonalFace2D, new Line2D(new Point2D(0, y), Constants.Vector2D.WorldX), tolerance);
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
