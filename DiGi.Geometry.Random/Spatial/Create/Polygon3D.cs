using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using System.Linq;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" /> within the specified <see cref="BoundingBox3D" />.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> that defines the spatial boundaries for the polygon generation.</param>
        /// <param name="pointCount">An <see cref="int" /> specifying the number of vertices to be generated for the <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" />.</param>
        /// <param name="seed">An <see cref="int" /> used as the seed for the random number generator; a value of -1 indicates a non-deterministic seed.</param>
        /// <param name="tolerance">A <see cref="double" /> specifying the geometric tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" /> generated within the <paramref name="boundingBox3D" />, or <see langword="null" /> if the <paramref name="boundingBox3D" /> is null.</returns>
        public static Polygon3D? Polygon3D(BoundingBox3D? boundingBox3D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon3D(boundingBox3D, pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Spatial.Classes.Polygon3D" /> within the specified <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" />.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> that defines the spatial boundaries for the polygon generation.</param>
        /// <param name="pointCount">The number of vertices to be generated for the resulting polygon.</param>
        /// <param name="random">The <see cref="T:System.Random" /> instance used to ensure randomness in plane selection and point placement.</param>
        /// <param name="tolerance">The double value specifying the geometric tolerance, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.Polygon3D" /> instance if a valid polygon could be generated; otherwise, <c>null</c>.</returns>
        public static Polygon3D? Polygon3D(BoundingBox3D? boundingBox3D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            Plane? plane = Plane(boundingBox3D, random, tolerance);
            if (plane == null)
            {
                return null;
            }

            PlanarIntersectionResult? planarIntersectionResult = Spatial.Create.PlanarIntersectionResult(plane, boundingBox3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return null;
            }

            IPolygonal2D? polygonal2D = planarIntersectionResult.GetGeometry2Ds<IPolygonal2D>()?.FirstOrDefault();
            if (polygonal2D == null)
            {
                return null;
            }

            Polygon2D? polygon2D = Planar.Random.Create.Polygon2D(polygonal2D, pointCount, random, tolerance);
            if (polygon2D == null)
            {
                return null;
            }

            return plane.Convert(polygon2D);
        }

        /// <summary>
        /// Generates a <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" /> within the specified spatial ranges using a specified number of points.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the boundaries along the X-axis.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the boundaries along the Y-axis.</param>
        /// <param name="z">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the boundaries along the Z-axis.</param>
        /// <param name="pointCount">The integer number of points to generate for the polygon.</param>
        /// <param name="seed">The integer seed value used for the random number generator.</param>
        /// <param name="tolerance">The double precision tolerance used for geometric operations, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" /> instance if the <paramref name="x" />, <paramref name="y" />, and <paramref name="z" /> ranges are not null; otherwise, null.</returns>
        public static Polygon3D? Polygon3D(Range<double>? x, Range<double>? y, Range<double>? z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon3D(x, y, z, pointCount, random, tolerance);
        }

        /// <summary>
        /// Creates a <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" /> within a three-dimensional space defined by the provided coordinate ranges.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the extent along the X-axis.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the extent along the Y-axis.</param>
        /// <param name="z">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the extent along the Z-axis.</param>
        /// <param name="pointCount">The number of points to be generated for the <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" />.</param>
        /// <param name="random">An instance of <see cref="System.Random" /> used for random point generation.</param>
        /// <param name="tolerance">The double precision tolerance value, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="DiGi.Geometry.Spatial.Classes.Polygon3D" /> if the <paramref name="x" />, <paramref name="y" />, <paramref name="z" />, and <paramref name="random" /> parameters are not null; otherwise, null.</returns>
        public static Polygon3D? Polygon3D(Range<double>? x, Range<double>? y, Range<double>? z, int pointCount, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return Polygon3D(Spatial.Create.BoundingBox3D(x, y, z), pointCount, random, tolerance);
        }
    }
}
