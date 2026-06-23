using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" /> within the specified <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" /> using a provided seed and tolerance.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" /> that defines the boundaries for the generated segment.</param>
        /// <param name="seed">An <see cref="System.Int32" /> value used to seed the random number generator; a value of -1 indicates a non-deterministic seed.</param>
        /// <param name="tolerance">A <see cref="System.Double" /> specifying the geometric tolerance, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A new <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" /> instance if <paramref name="boundingBox2D" /> is not null; otherwise, null.</returns>
        public static Segment2D? Segment2D(BoundingBox2D? boundingBox2D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Segment2D(boundingBox2D, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" /> within the specified <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" />.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" /> that defines the boundaries for generating the segment.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random coordinates.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly generated <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" />, or <c>null</c> if the <paramref name="boundingBox2D" /> is <c>null</c>, the <paramref name="random" /> instance is <c>null</c>, or the bounding box's minimum or maximum points are null.</returns>
        public static Segment2D? Segment2D(BoundingBox2D? boundingBox2D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" /> based on the provided coordinate ranges, a random seed, and a geometric tolerance.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}" /> defining the boundaries for the X-axis.</param>
        /// <param name="y">The <see cref="Range{T}" /> defining the boundaries for the Y-axis.</param>
        /// <param name="seed">The <see cref="int" /> seed value used to initialize the random number generator.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value used for geometric operations, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D" /> if both <paramref name="x" /> and <paramref name="y" /> are not null; otherwise, null.</returns>
        public static Segment2D? Segment2D(Range<double>? x, Range<double>? y, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Segment2D(x, y, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D"/> within the specified X and Y ranges, ensuring that the resulting segment's length is at least the specified <paramref name="tolerance"/>.
        /// </summary>
        /// <param name="x">The <see cref="T:DiGi.Core.Classes.Range`1"/> defining the boundaries for the X coordinate.</param>
        /// <param name="y">The <see cref="T:DiGi.Core.Classes.Range`1"/> defining the boundaries for the Y coordinate.</param>
        /// <param name="random">The <see cref="T:System.Random"/> instance used to generate random coordinates.</param>
        /// <param name="tolerance">The minimum length required for the generated <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D"/>. Defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Planar.Classes.Segment2D"/> that satisfies the length requirement, or <see langword="null"/> if any of the required parameters (<paramref name="x"/>, <paramref name="y"/>, or <paramref name="random"/>) are <see langword="null"/>.</returns>
        public static Segment2D? Segment2D(Range<double>? x, Range<double>? y, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            Segment2D? result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Segment2D(Point2D(x, y, random), Point2D(x, y, random));
                length = result.Length;
            }

            return result;
        }
    }
}