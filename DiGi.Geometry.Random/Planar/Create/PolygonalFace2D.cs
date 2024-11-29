using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Planar.Random
{
    public static partial class Create
    {
        public static PolygonalFace2D PolygonalFace2D(Range<double> x, Range<double> y, Range<int> pointCount, Range<int> internalEdgeCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || pointCount == null || internalEdgeCount == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return PolygonalFace2D(x, y, pointCount, internalEdgeCount, random, tolerance);
        }

        public static PolygonalFace2D PolygonalFace2D(Range<double> x, Range<double> y, Range<int> pointCount, Range<int> internalEdgeCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || pointCount == null || internalEdgeCount == null || random == null)
            {
                return null;
            }

            Polygon2D externalEdge = Polygon2D(x, y, pointCount, random, tolerance);

            int internalEdgeCount_Temp = DiGi.Core.Query.Random(random, internalEdgeCount);

            List<IPolygonal2D> internalEdges = null;
            if(internalEdgeCount_Temp > 0)
            {
                internalEdges = new List<IPolygonal2D>();
                for (int i = 0; i < internalEdgeCount_Temp; i++)
                {
                    Polygon2D internalEdge = Polygon2D(externalEdge, pointCount, random, tolerance);
                    if(internalEdge != null)
                    {
                        internalEdges.Add(internalEdge);
                    }
                }

                internalEdges = Query.Intersection<IPolygonal2D, IPolygonal2D>(internalEdges);

                string text = DiGi.Core.Convert.ToSystem_String(internalEdges);

                for (int i = 0; i < internalEdges.Count; i++)
                {
                    internalEdges[i] = Polygon2D(internalEdges[i], pointCount, random, tolerance);
                }

                internalEdges.Sort((x, y) => y.GetArea().CompareTo(x.GetArea()));

                if (internalEdges.Count > internalEdgeCount_Temp)
                {
                    internalEdges.RemoveRange(internalEdgeCount_Temp, internalEdges.Count - internalEdgeCount_Temp);
                }
            }

            return Planar.Create.PolygonalFace2D(externalEdge, internalEdges, tolerance);
        }
    }
}
