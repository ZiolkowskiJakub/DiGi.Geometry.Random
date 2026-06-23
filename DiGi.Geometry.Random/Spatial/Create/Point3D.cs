using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Spatial.Classes.Point3D" /> within the specified <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" />.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> that defines the boundaries for generating the point.</param>
        /// <param name="seed">An <see cref="System.Int32" /> value used to seed the random number generator.</param>
        /// <param name="tolerance">A <see cref="System.Double" /> value representing the distance tolerance, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.Point3D" /> located within the <paramref name="boundingBox3D" />, or <see langword="null" /> if the <paramref name="boundingBox3D" /> is <see langword="null" />.</returns>
        public static Point3D? Point3D(BoundingBox3D? boundingBox3D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point3D(boundingBox3D, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Point3D" /> within the specified <see cref="BoundingBox3D" />.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> that defines the spatial boundaries for the point generation.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random coordinates.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly generated <see cref="Classes.Point3D" /> within the boundaries of the <paramref name="boundingBox3D" />, or <see langword="null" /> if the <paramref name="boundingBox3D" />, <paramref name="random" />, or the bounding box's minimum or maximum points are null.</returns>
        public static Point3D? Point3D(BoundingBox3D? boundingBox3D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
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

            return Point3D(new Range<double>(min.X, max.X), new Range<double>(min.Y, max.Y), new Range<double>(min.Z, max.Z), random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Point3D" /> within the specified coordinate ranges.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}" /> defining the boundaries for the X-coordinate.</param>
        /// <param name="y">The <see cref="Range{T}" /> defining the boundaries for the Y-coordinate.</param>
        /// <param name="z">The <see cref="Range{T}" /> defining the boundaries for the Z-coordinate.</param>
        /// <param name="seed">An <see cref="int" /> value used to seed the random number generator.</param>
        /// <param name="tolerance">A <see cref="double" /> specifying the geometric tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Point3D" /> instance if all provided ranges are non-null; otherwise, <see langword="null" />.</returns>
        public static Point3D? Point3D(Range<double>? x, Range<double>? y, Range<double>? z, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point3D(x, y, z, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Point3D"/> based on the specified coordinate ranges and tolerance.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> for the X-coordinate.</param>
        /// <param name="y">The <see cref="Range{T}"/> for the Y-coordinate.</param>
        /// <param name="z">The <see cref="Range{T}"/> for the Z-coordinate.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random values.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A <see cref="Classes.Point3D"/> if <paramref name="x"/>, <paramref name="y"/>, <paramref name="z"/>, and <paramref name="random"/> are not null; otherwise, <c>null</c>.</returns>
        public static Point3D? Point3D(Range<double>? x, Range<double>? y, Range<double>? z, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return new Point3D(DiGi.Core.Query.Random(random, x, tolerance), DiGi.Core.Query.Random(random, y, tolerance), DiGi.Core.Query.Random(random, z, tolerance));
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Point3D" /> within the specified <see cref="Classes.Polygon3D" /> using a provided seed and tolerance.
        /// </summary>
        /// <param name="polygon3D">The <see cref="Classes.Polygon3D" /> from which to generate the point.</param>
        /// <param name="seed">An <see cref="int" /> value used as the seed for the random number generator.</param>
        /// <param name="tolerance">A <see cref="double" /> representing the distance tolerance, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Point3D" /> located within the <paramref name="polygon3D" />, or <see langword="null" /> if the <paramref name="polygon3D" /> is <see langword="null" />.</returns>
        public static Point3D? Point3D(Polygon3D? polygon3D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygon3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Point3D(polygon3D, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Point3D" /> within the boundaries of the specified <see cref="Classes.Polygon3D" />.
        /// </summary>
        /// <param name="polygon3D">The <see cref="Classes.Polygon3D" /> instance used as the boundary for generating the point.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random coordinates.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Point3D" /> instance representing a random point within the <paramref name="polygon3D" />, or <c>null</c> if the <paramref name="polygon3D" /> is null, its associated plane is not defined, or a valid 2D point cannot be generated.</returns>
        public static Point3D? Point3D(Polygon3D? polygon3D, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (polygon3D == null)
            {
                return null;
            }

            Plane? plane = polygon3D.Plane;
            if (plane == null)
            {
                return null;
            }

            Point2D? point2D = Planar.Random.Create.Point2D(polygon3D.Geometry2D, random, tolerance);
            if (point2D == null)
            {
                return null;
            }

            return plane.Convert(point2D);
        }
    }
}