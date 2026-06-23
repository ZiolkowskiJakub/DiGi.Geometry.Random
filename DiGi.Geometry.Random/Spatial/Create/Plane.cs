using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a <see cref="Classes.Plane" /> based on the provided <see cref="BoundingBox3D" />, using a random seed and a specified tolerance.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> used to define the spatial constraints for the plane generation.</param>
        /// <param name="seed">An <see cref="int" /> value used as the seed for the random number generator.</param>
        /// <param name="tolerance">A <see cref="double" /> representing the geometric tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Plane" /> instance if the <paramref name="boundingBox3D" /> is not null; otherwise, <c>null</c>.</returns>
        public static Plane? Plane(BoundingBox3D? boundingBox3D, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Plane(boundingBox3D, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Plane" /> based on the provided <see cref="BoundingBox3D" />, <see cref="System.Random" /> instance, and tolerance.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> used to constrain the random point generation for the plane.</param>
        /// <param name="random">The <see cref="System.Random" /> instance used to generate random values.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance value used during the generation process, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly generated <see cref="Classes.Plane" /> if successful; otherwise, <c>null</c>.</returns>
        public static Plane? Plane(BoundingBox3D? boundingBox3D, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            Point3D? point3D = Point3D(boundingBox3D, random, tolerance);
            if (point3D == null)
            {
                return null;
            }

            Vector3D? vector3D = Vector3D(random, tolerance);
            if (vector3D == null)
            {
                return null;
            }

            return new Plane(point3D, vector3D);
        }

        /// <summary>
        /// Generates a <see cref="Classes.Plane" /> based on the specified coordinate ranges.
        /// </summary>
        /// <param name="x">The range of the X-axis as a <see cref="Range{T}" /> of <see cref="double" /> values.</param>
        /// <param name="y">The range of the Y-axis as a <see cref="Range{T}" /> of <see cref="double" /> values.</param>
        /// <param name="z">The range of the Z-axis as a <see cref="Range{T}" /> of <see cref="double" /> values.</param>
        /// <param name="seed">An <see cref="int" /> value used to seed the random number generator.</param>
        /// <param name="tolerance">A <see cref="double" /> specifying the distance tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Plane" /> instance if <paramref name="x" />, <paramref name="y" />, and <paramref name="z" /> are not null; otherwise, <c>null</c>.</returns>
        public static Plane? Plane(Range<double>? x, Range<double>? y, Range<double>? z, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Plane(x, y, z, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="Classes.Plane" /> based on the provided coordinate ranges, a random number generator, and a tolerance value.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}"/> defining the range for the X-coordinate of the point on the plane.</param>
        /// <param name="y">The <see cref="Range{T}"/> defining the range for the Y-coordinate of the point on the plane.</param>
        /// <param name="z">The <see cref="Range{T}"/> defining the range for the Z-coordinate of the point on the plane.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used to generate random values for the point and vector.</param>
        /// <param name="tolerance">The <see cref="double"/> tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Plane" /> instance if a valid <see cref="Classes.Point3D" /> and <see cref="Classes.Vector3D" /> can be generated; otherwise, <c>null</c>.</returns>
        public static Plane? Plane(Range<double>? x, Range<double>? y, Range<double>? z, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            Point3D? point3D = Point3D(x, y, z, random, tolerance);
            if (point3D == null)
            {
                return null;
            }

            Vector3D? vector3D = Vector3D(random, tolerance);
            if (vector3D == null)
            {
                return null;
            }

            return new Plane(point3D, vector3D);
        }
    }
}