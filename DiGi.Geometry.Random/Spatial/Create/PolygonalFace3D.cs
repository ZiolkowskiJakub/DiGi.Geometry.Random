using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static PolygonalFace3D PolygonalFace3D(BoundingBox3D boundingBox3D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            Polygon3D externalEdge = Polygon3D(boundingBox3D, pointCount, seed, tolerance);
            if(externalEdge == null)
            {
                return null;
            }

            Polygon2D externalEdge2D = externalEdge.Geometry2D;
            if(externalEdge2D == null)
            {
                return null;
            }

            Plane plane = externalEdge.Plane;
            if(plane != null)
            {
                return null;
            }


            List<Polygon2D> internalEdge2Ds = null;

            bool internalEdge = DiGi.Core.Query.Random(seed);
            if(internalEdge)
            {
                internalEdge2Ds = new List<Polygon2D>();

                int count = DiGi.Core.Query.Random(1, pointCount, seed);
                for(int i =0; i < count; i++)
                {
                    Polygon2D internalEdge2D = Planar.Random.Create.Polygon2D(externalEdge2D, pointCount, seed, tolerance);
                    if(internalEdge2D == null)
                    {
                        continue;
                    }

                    if(internalEdge2Ds.Find(x => x.InRange(internalEdge2D)) != null)
                    {
                        continue;
                    }

                    internalEdge2Ds.Add(internalEdge2D);
                }
            }

            PolygonalFace2D polygonalFace2D = Planar.Create.PolygonalFace2D(externalEdge2D, internalEdge2Ds, tolerance);
            if(polygonalFace2D == null)
            {
                return null;
            }

            return new PolygonalFace3D(plane, polygonalFace2D);
        }

        public static PolygonalFace3D PolygonalFace3D(Range<double> x, Range<double> y, Range<double> z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            return PolygonalFace3D(Spatial.Create.BoundingBox3D(x, y, z), pointCount, seed, tolerance);

        }
    }
}
