using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> within the specified <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> using a random seed and tolerance.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> that defines the spatial bounds for the face generation.</param>
        /// <param name="pointCount">The <see cref="System.Int32" /> number of points to be used in the creation of the polygonal face.</param>
        /// <param name="seed">The <see cref="System.Int32" /> seed value for the random number generator.</param>
        /// <param name="tolerance">The <see cref="System.Double" /> tolerance value, defaulting to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />, used for geometric calculations.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> if the <paramref name="boundingBox3D" /> is not null; otherwise, null.</returns>
        public static PolygonalFace3D? PolygonalFace3D(BoundingBox3D? boundingBox3D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return PolygonalFace3D(boundingBox3D, pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> within the specified bounding box.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> that defines the spatial boundaries for generating the face.</param>
        /// <param name="pointCount">The <see cref="T:System.Int32" /> number of points to be used in the generation of the polygons.</param>
        /// <param name="random">The <see cref="T:System.Random" /> instance used for stochastic generation.</param>
        /// <param name="tolerance">The <see cref="T:System.Double" /> distance tolerance for geometric operations, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A randomly generated <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> instance if the generation is successful; otherwise, <c>null</c>.</returns>
        public static PolygonalFace3D? PolygonalFace3D(BoundingBox3D? boundingBox3D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            Polygon3D? externalEdge = Polygon3D(boundingBox3D, pointCount, random, tolerance);
            if (externalEdge == null)
            {
                return null;
            }

            Polygon2D? externalEdge2D = externalEdge.Geometry2D;
            if (externalEdge2D == null)
            {
                return null;
            }

            Plane? plane = externalEdge.Plane;
            if (plane != null)
            {
                return null;
            }

            List<Polygon2D>? internalEdge2Ds = null;

            bool internalEdge = DiGi.Core.Query.Random(random);
            if (internalEdge)
            {
                internalEdge2Ds = [];

                int count = DiGi.Core.Query.Random(random, 1, pointCount);
                for (int i = 0; i < count; i++)
                {
                    Polygon2D? internalEdge2D = Planar.Random.Create.Polygon2D(externalEdge2D, pointCount, random, tolerance);
                    if (internalEdge2D == null)
                    {
                        continue;
                    }

                    if (internalEdge2Ds.Find(x => x.InRange(internalEdge2D)) != null)
                    {
                        continue;
                    }

                    internalEdge2Ds.Add(internalEdge2D);
                }
            }

            PolygonalFace2D? polygonalFace2D = Planar.Create.PolygonalFace2D(externalEdge2D, internalEdge2Ds, tolerance);
            if (polygonalFace2D == null)
            {
                return null;
            }

            return new PolygonalFace3D(plane, polygonalFace2D);
        }

        /// <summary>
        /// Generates a <see cref="DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> within the specified spatial ranges using a set number of points.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}" /> for the X-axis coordinate.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}" /> for the Y-axis coordinate.</param>
        /// <param name="z">The <see cref="DiGi.Core.Classes.Range{T}" /> for the Z-axis coordinate.</param>
        /// <param name="pointCount">The number of points to be generated for the polygonal face.</param>
        /// <param name="seed">The seed value used for the random number generator. A value of -1 typically indicates a default or random seed.</param>
        /// <param name="tolerance">The geometric tolerance used for operations, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> instance if the <paramref name="x" />, <paramref name="y" />, and <paramref name="z" /> ranges are provided; otherwise, <c>null</c>.</returns>
        public static PolygonalFace3D? PolygonalFace3D(Range<double>? x, Range<double>? y, Range<double>? z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return PolygonalFace3D(x, y, z, pointCount, random, tolerance);
        }

        /// <summary>
        /// Creates a <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> based on the specified X, Y, and Z ranges.
        /// </summary>
        /// <param name="x">The <see cref="T:DiGi.Core.Classes.Range`1" /> defining the extent of the X-axis.</param>
        /// <param name="y">The <see cref="T:DiGi.Core.Classes.Range`1" /> defining the extent of the Y-axis.</param>
        /// <param name="z">The <see cref="T:DiGi.Core.Classes.Range`1" /> defining the extent of the Z-axis.</param>
        /// <param name="pointCount">The integer number of points to generate for the polygonal face.</param>
        /// <param name="random">The <see cref="T:System.Random" /> instance used for randomizing point positions.</param>
        /// <param name="tolerance">The double value specifying the tolerance for geometric operations, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.PolygonalFace3D" /> if <paramref name="x" />, <paramref name="y" />, <paramref name="z" />, and <paramref name="random" /> are not null; otherwise, null.</returns>
        public static PolygonalFace3D? PolygonalFace3D(Range<double>? x, Range<double>? y, Range<double>? z, int pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return PolygonalFace3D(Spatial.Create.BoundingBox3D(x, y, z), pointCount, random, tolerance);
        }
    }
}
