using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a random <see cref="Classes.Vector3D"/> using the specified <paramref name="seed"/> and <paramref name="tolerance"/>.
        /// </summary>
        /// <param name="seed">The <see cref="int"/> seed used to initialize the random number generator.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance for the operation, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A nullable <see cref="Classes.Vector3D"/> representing the generated random vector.</returns>
        public static Vector3D? Vector3D(int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector3D(random, tolerance);
        }

        /// <summary>
        /// Generates a random unit <see cref="T:DiGi.Geometry.Spatial.Classes.Vector3D" /> by creating a random vector and ensuring its length exceeds the specified <paramref name="tolerance" /> before normalization.
        /// </summary>
        /// <param name="random">The <see cref="T:System.Random" /> instance used to generate the random components of the vector. If this <see cref="T:System.Random" /> is null, the method returns null.</param>
        /// <param name="tolerance">A <see cref="T:System.Double" /> value specifying the minimum length threshold that the generated vector must meet before it can be normalized. The default value is <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A unit <see cref="T:DiGi.Geometry.Spatial.Classes.Vector3D" /> representing a random direction, or null if the <paramref name="random" /> instance is null.</returns>
        public static Vector3D? Vector3D(System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (random == null)
            {
                return null;
            }

            Vector3D? result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector3D(DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance), DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance), DiGi.Core.Query.Random(random, new Range<double>(0, 1), tolerance));
                length = result.Length;
            }

            return result?.Unit;
        }

        /// <summary>
        /// Generates a <see cref="Classes.Vector3D" /> based on the provided <see cref="BoundingBox3D" />, utilizing a random seed and a specific tolerance.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> used as the basis for generating the vector.</param>
        /// <param name="seed">An <see cref="int" /> value used to initialize the random number generator.</param>
        /// <param name="tolerance">A <see cref="double" /> value representing the tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Vector3D" /> if the <paramref name="boundingBox3D" /> is not null; otherwise, <see langword="null" />.</returns>
        public static Vector3D? Vector2D(BoundingBox3D? boundingBox3D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector3D(boundingBox3D, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Vector3D" /> within the specified <see cref="BoundingBox3D" />.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> that defines the spatial boundaries for generating the random vector.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to produce the random coordinates.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly generated <see cref="Classes.Vector3D" /> within the specified <paramref name="boundingBox3D" />, or <see langword="null" /> if the <paramref name="boundingBox3D" />, <paramref name="random" />, or any of the bounding box's boundary points are null.</returns>
        public static Vector3D? Vector3D(BoundingBox3D? boundingBox3D, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            Point3D? min = boundingBox3D.Min;
            if (min == null)
            {
                return null;
            }

            Point3D? max = boundingBox3D.Max;
            if (max == null)
            {
                return null;
            }

            return Vector3D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), new Range<double>(min.Z, max.Z), random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Vector3D"/> within the specified ranges for each axis.
        /// </summary>
        /// <param name="x">The range for the X-coordinate.</param>
        /// <param name="y">The range for the Y-coordinate.</param>
        /// <param name="z">The range for the Z-coordinate.</param>
        /// <param name="seed">An <see cref="int"/> value used to seed the random number generator.</param>
        /// <param name="tolerance">A <see cref="double"/> representing the distance tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Vector3D"/> if both <paramref name="x" /> and <paramref name="y" /> are not null; otherwise, <c>null</c>.</returns>
        public static Vector3D? Vector3D(Range<double>? x, Range<double>? y, Range<double>? z, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Vector3D(x, y, z, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Vector3D"/> within the specified ranges, ensuring that the resulting vector's length is at least the specified tolerance.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> for the X component of the vector.</param>
        /// <param name="y">The <see cref="Range{T}"/> for the Y component of the vector.</param>
        /// <param name="z">The <see cref="Range{T}"/> for the Z component of the vector.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random values.</param>
        /// <param name="tolerance">The minimum length threshold that the resulting <see cref="Classes.Vector3D"/> must meet; defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Vector3D"/> that satisfies the length requirement, or <see langword="null"/> if <paramref name="x"/>, <paramref name="y"/>, or <paramref name="random"/> is <see langword="null"/>.</returns>
        public static Vector3D? Vector3D(Range<double>? x, Range<double>? y, Range<double>? z, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || random == null)
            {
                return null;
            }

            Vector3D? result = null;

            double length = 0;
            while (length < tolerance)
            {
                result = new Vector3D(DiGi.Core.Query.Random(random, x, tolerance), DiGi.Core.Query.Random(random, y, tolerance), DiGi.Core.Query.Random(random, z, tolerance));
                length = result.Length;
            }

            return result;
        }
    }
}