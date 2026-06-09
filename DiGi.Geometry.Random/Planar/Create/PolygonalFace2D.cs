using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        /// <summary>
        /// Generates a <see cref="DiGi.Geometry.Planar.Classes.PolygonalFace2D" /> based on the specified coordinate ranges and complexity constraints.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the range of X-coordinates.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the range of Y-coordinates.</param>
        /// <param name="pointCount">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the allowed number of points.</param>
        /// <param name="internalEdgeCount">The <see cref="DiGi.Core.Classes.Range{T}" /> defining the allowed number of internal edges.</param>
        /// <param name="seed">An <see cref="int" /> used as a seed for random generation. A value of -1 indicates a random seed.</param>
        /// <param name="tolerance">A <see cref="double" /> specifying the geometric tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance" />.</param>
        /// <returns>A <see cref="DiGi.Geometry.Planar.Classes.PolygonalFace2D" /> if <paramref name="x" />, <paramref name="y" />, <paramref name="pointCount" />, and <paramref name="internalEdgeCount" /> are provided; otherwise, null.</returns>
        public static PolygonalFace2D? PolygonalFace2D(Range<double>? x, Range<double>? y, Range<int>? pointCount, Range<int>? internalEdgeCount, int seed = -1, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || pointCount == null || internalEdgeCount == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return PolygonalFace2D(x, y, pointCount, internalEdgeCount, random, tolerance);
        }

        /// <summary>
        /// Generates a random <see cref="DiGi.Geometry.Planar.Classes.PolygonalFace2D"/> based on the specified coordinate ranges, point counts, and number of internal edges.
        /// </summary>
        /// <param name="x">The <see cref="DiGi.Core.Classes.Range{T}"/> specifying the range for the X-axis coordinates.</param>
        /// <param name="y">The <see cref="DiGi.Core.Classes.Range{T}"/> specifying the range for the Y-axis coordinates.</param>
        /// <param name="pointCount">The <see cref="DiGi.Core.Classes.Range{T}"/> specifying the number of points to be used in the polygons.</param>
        /// <param name="internalEdgeCount">The <see cref="DiGi.Core.Classes.Range{T}"/> specifying the number of internal edges (holes) to generate within the face.</param>
        /// <param name="random">The <see cref="System.Random"/> instance used for random generation.</param>
        /// <param name="tolerance">The <see cref="double"/> value representing the geometric tolerance, which defaults to <see cref="DiGi.Core.Constants.Tolerance.MacroDistance"/>.</param>
        /// <returns>A randomly generated <see cref="DiGi.Geometry.Planar.Classes.PolygonalFace2D"/> if all required parameters are provided; otherwise, <c>null</c>.</returns>
        public static PolygonalFace2D? PolygonalFace2D(Range<double>? x, Range<double>? y, Range<int>? pointCount, Range<int>? internalEdgeCount, System.Random? random, double tolerance = DiGi.Core.Constants.Tolerance.MacroDistance)
        {
            if (x == null || y == null || pointCount == null || internalEdgeCount == null || random == null)
            {
                return null;
            }

            Polygon2D? externalEdge = Polygon2D(x, y, pointCount, random, tolerance);

            int internalEdgeCount_Temp = DiGi.Core.Query.Random(random, internalEdgeCount);

            List<IPolygonal2D>? internalEdges = null;
            if (internalEdgeCount_Temp > 0)
            {
                internalEdges = [];
                for (int i = 0; i < internalEdgeCount_Temp; i++)
                {
                    Polygon2D? internalEdge = Polygon2D(externalEdge, pointCount, random, tolerance);
                    if (internalEdge != null)
                    {
                        internalEdges.Add(internalEdge);
                    }
                }

                internalEdges = Query.Intersection<IPolygonal2D, IPolygonal2D>(internalEdges);
                if (internalEdges is not null)
                {
                    for (int i = 0; i < internalEdges.Count; i++)
                    {
                        Polygon2D? polygon2D = Polygon2D(internalEdges[i], pointCount, random, tolerance);
                        if (polygon2D is null)
                        {
                            continue;
                        }

                        internalEdges[i] = polygon2D;
                    }

                    internalEdges.Sort((x, y) => y.GetArea().CompareTo(x.GetArea()));

                    if (internalEdges.Count > internalEdgeCount_Temp)
                    {
                        internalEdges.RemoveRange(internalEdgeCount_Temp, internalEdges.Count - internalEdgeCount_Temp);
                    }
                }
            }

            return Planar.Create.PolygonalFace2D(externalEdge, internalEdges, tolerance);
        }
    }
}
