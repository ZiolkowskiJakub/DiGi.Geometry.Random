using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a random <see cref="Classes.Vector2D" /> based on the specified seed and tolerance.
        /// </summary>
        /// <param name="seed">The <see cref="int" /> seed used to initialize the random number generator.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly generated <see cref="Classes.Vector2D" /> instance.</returns>
        public static Vector2D? Vector2D(int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector2D(random, tolerance);
        }

        /// <summary>
        /// Generates a random unit <see cref="T:DiGi.Geometry.Planar.Classes.Vector2D" /> by iteratively creating vectors until the length exceeds the specified <paramref name="tolerance" />.
        /// </summary>
        /// <param name="random">The <see cref="T:System.Random" /> instance used to generate random values.</param>
        /// <param name="tolerance">The minimum length threshold that a generated vector must exceed before being normalized, defaulting to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A unit <see cref="T:DiGi.Geometry.Planar.Classes.Vector2D" /> representing the normalized direction of the generated vector, or <see langword="null" /> if the <paramref name="random" /> instance is null.</returns>
        public static Vector2D? Vector2D(System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (random == null)
            {
                return null;
            }

            Vector2D? result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector2D(DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance), DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance));
                length = result.Length;
            }

            return result?.Unit;
        }

        /// <summary>
        /// Generates a <see cref="T:DiGi.Geometry.Planar.Classes.Vector2D" /> based on the provided <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" />, using a random seed and a specified distance tolerance.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" /> used to define the area for vector generation.</param>
        /// <param name="seed">An <see cref="System.Int32" /> value used as a seed for the random number generator.</param>
        /// <param name="tolerance">A <see cref="System.Double" /> value representing the distance tolerance, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Planar.Classes.Vector2D" /> if the <paramref name="boundingBox2D" /> is not null; otherwise, null.</returns>
        public static Vector2D? Vector2D(BoundingBox2D? boundingBox2D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector2D(boundingBox2D, random, tolerance);
        }

        /// <summary>
        /// Generates a <see cref="T:DiGi.Geometry.Planar.Classes.Vector2D" /> based on the provided <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" />, using a random generator and a specified tolerance.
        /// </summary>
        /// <param name="boundingBox2D">The <see cref="T:DiGi.Geometry.Planar.Classes.BoundingBox2D" /> used to define the spatial bounds for vector generation.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random values within the ranges of the bounding box.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Planar.Classes.Vector2D" /> if the <paramref name="boundingBox2D" /> and its minimum and maximum corners are not null; otherwise, <see langword="null" />.</returns>
        public static Vector2D? Vector2D(BoundingBox2D? boundingBox2D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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

            return Vector2D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Vector2D"/> within the specified X and Y ranges using a provided seed and distance tolerance.
        /// </summary>
        /// <param name="x">The nullable <see cref="Range{T}"/> for the X-coordinate. If <paramref name="x"/> is null, the method returns null.</param>
        /// <param name="y">The nullable <see cref="Range{T}"/> for the Y-coordinate. If <paramref name="y"/> is null, the method returns null.</param>
        /// <param name="seed">The <see cref="int"/> seed used to initialize the random number generator.</param>
        /// <param name="tolerance">The <see cref="double"/> distance tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Vector2D"/> if both <paramref name="x"/> and <paramref name="y"/> are non-null; otherwise, null.</returns>
        public static Vector2D? Vector2D(Range<double>? x, Range<double>? y, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector2D(x, y, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Vector2D"/> within the specified X and Y ranges, ensuring that the length of the resulting vector meets or exceeds the specified tolerance.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> for the X coordinate.</param>
        /// <param name="y">The <see cref="Range{T}"/> for the Y coordinate.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random values.</param>
        /// <param name="tolerance">The minimum length threshold that the generated <see cref="Classes.Vector2D"/> must satisfy. Defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Vector2D"/> that satisfies the tolerance requirement, or <see langword="null"/> if <paramref name="x"/>, <paramref name="y"/>, or <paramref name="random"/> is null.</returns>
        public static Vector2D? Vector2D(Range<double>? x, Range<double>? y, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            Vector2D? result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector2D(DiGi.Core.Query.Random(random, x, tolerance), DiGi.Core.Query.Random(random, y, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}