using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a <see cref="Classes.Polyhedron" /> within the specified <see cref="BoundingBox3D" /> using a random distribution of points.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="BoundingBox3D" /> that defines the spatial boundaries for the polyhedron generation.</param>
        /// <param name="pointCount">The number of points to be used in the creation of the polyhedron.</param>
        /// <param name="seed">The <see cref="int" /> seed value for the random number generator; a value of -1 indicates a non-deterministic seed.</param>
        /// <param name="tolerance">The <see cref="double" /> tolerance used for geometric operations, defaulting to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Polyhedron" /> generated within the specified boundaries, or <see langword="null" /> if the <paramref name="boundingBox3D" /> is null.</returns>
        public static Polyhedron? Polyhedron(BoundingBox3D? boundingBox3D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polyhedron(boundingBox3D, pointCount, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="T:DiGi.Geometry.Spatial.Classes.Polyhedron" /> based on a provided <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" />, using a randomly generated polygonal face and an extrusion length derived from the bounding box constraints.
        /// </summary>
        /// <param name="boundingBox3D">The <see cref="T:DiGi.Geometry.Spatial.Classes.BoundingBox3D" /> that defines the spatial boundaries for the generation process.</param>
        /// <param name="pointCount">An <see cref="System.Int32" /> specifying the number of points used to create the base polygonal face.</param>
        /// <param name="random">A <see cref="System.Random" /> instance used to randomize the face generation and the final extrusion length.</param>
        /// <param name="tolerance">A <see cref="System.Double" /> representing the distance tolerance for geometric operations, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.Polyhedron" /> if the object was successfully created; otherwise, <c>null</c>.</returns>
        public static Polyhedron? Polyhedron(BoundingBox3D? boundingBox3D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            PolygonalFace3D? polygonalFace3D = PolygonalFace3D(boundingBox3D, pointCount, random, tolerance);
            if (polygonalFace3D == null)
            {
                return null;
            }

            Plane? plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            Vector3D? normal = plane.Normal;
            if (normal == null)
            {
                return null;
            }

            List<IPolygonal3D>? edges = polygonalFace3D.Edges;
            if (edges is null)
            {
                return null;
            }

            double length = double.MaxValue;
            foreach (IPolygonal3D edge in edges)
            {
                if (edge == null)
                {
                    continue;
                }

                List<Point3D>? point3Ds = edge.GetPoints();
                if (point3Ds == null || point3Ds.Count == 0)
                {
                    continue;
                }

                for (int i = 0; i < point3Ds.Count; i++)
                {
                    IntersectionResult3D? intersectionResult3D = Spatial.Create.IntersectionResult3D(boundingBox3D, point3Ds[i], normal, tolerance);
                    if (intersectionResult3D == null || !intersectionResult3D.Any())
                    {
                        continue;
                    }

                    List<IGeometry3D>? geometry3Ds = intersectionResult3D.GetGeometry3Ds<IGeometry3D>();
                    if (geometry3Ds != null)
                    {
                        foreach (IGeometry3D geometry3D in geometry3Ds)
                        {
                            double length_Temp = double.NaN;
                            if (geometry3D is Point3D point3D)
                            {
                                length_Temp = point3Ds[i].Distance(point3D);
                            }
                            else if (geometry3D is Segment3D segment3D)
                            {
                                length_Temp = segment3D.Length;
                            }

                            if (!double.IsNaN(length_Temp) && length_Temp < length)
                            {
                                length = length_Temp;
                            }
                        }
                    }
                }
            }

            if (double.IsNaN(length) || length == double.MaxValue)
            {
                return null;
            }

            length = DiGi.Core.Query.Random(random, 0, length, tolerance);
            if (length == 0)
            {
                return null;
            }

            return Spatial.Create.Polyhedron(polygonalFace3D, normal * length);
        }

        /// <summary>
        /// Creates a <see cref="Classes.Polyhedron" /> based on the specified spatial ranges and point count.
        /// </summary>
        /// <param name="x">The <see cref="Range{T}" /> defining the extent of the X-axis.</param>
        /// <param name="y">The <see cref="Range{T}" /> defining the extent of the Y-axis.</param>
        /// <param name="z">The <see cref="Range{T}" /> defining the extent of the Z-axis.</param>
        /// <param name="pointCount">The number of points to generate for the construction of the <see cref="Classes.Polyhedron" />.</param>
        /// <param name="seed">The seed value used for the random number generator; a value of -1 indicates a random seed.</param>
        /// <param name="tolerance">The geometric tolerance used during creation, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="Classes.Polyhedron" /> instance if <paramref name="x" />, <paramref name="y" />, and <paramref name="z" /> are all provided; otherwise, null.</returns>
        public static Polyhedron? Polyhedron(Range<double>? x, Range<double>? y, Range<double>? z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polyhedron(x, y, z, pointCount, random, tolerance);
        }

        /// <summary>
        /// Creates a <see cref="T:DiGi.Geometry.Spatial.Classes.Polyhedron" /> within a three-dimensional space defined by the specified spatial ranges.
        /// </summary>
        /// <param name="x">The <see cref="T:DiGi.Core.Classes.Range`1" /> of <see cref="T:System.Double" /> defining the extent along the X-axis.</param>
        /// <param name="y">The <see cref="T:DiGi.Core.Classes.Range`1" /> of <see cref="T:System.Double" /> defining the extent along the Y-axis.</param>
        /// <param name="z">The <see cref="T:DiGi.Core.Classes.Range`1" /> of <see cref="T:System.Double" /> defining the extent along the Z-axis.</param>
        /// <param name="pointCount">The number of points to be used in the generation of the <see cref="T:DiGi.Geometry.Spatial.Classes.Polyhedron" />.</param>
        /// <param name="random">An instance of <see cref="T:System.Random" /> used for random point distribution.</param>
        /// <param name="tolerance">The distance tolerance used for geometric operations, which defaults to <see cref="F:DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="T:DiGi.Geometry.Spatial.Classes.Polyhedron" /> if the spatial ranges and <paramref name="random" /> are not null; otherwise, null.</returns>
        public static Polyhedron? Polyhedron(Range<double>? x, Range<double>? y, Range<double>? z, int pointCount, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return Polyhedron(Spatial.Create.BoundingBox3D(x, y, z), pointCount, random, tolerance);
        }
    }
}