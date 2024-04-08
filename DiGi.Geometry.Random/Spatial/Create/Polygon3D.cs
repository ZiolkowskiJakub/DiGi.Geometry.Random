using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Linq;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static Polygon3D Polygon3D(BoundingBox3D boundingBox3D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            Plane plane = Plane(boundingBox3D, seed, tolerance);
            if(plane == null)
            {
                return null;
            }

            PlanarIntersectionResult planarIntersectionResult = Spatial.Create.PlanarIntersectionResult(plane, boundingBox3D, tolerance);
            if(planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return null;
            }

            IPolygonal2D polygonal2D = planarIntersectionResult.GetGeometry2Ds<IPolygonal2D>()?.FirstOrDefault();
            if(polygonal2D == null)
            {
                return null;
            }

            IPolygonal3D polygonal3D = plane.Convert(polygonal2D);
            if (polygonal2D == null)
            {
                return null;
            }

            throw new System.NotImplementedException();
        }

        public static Polygon3D Polygon3D(Range<double> x, Range<double> y, Range<double> z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            return Polygon3D(Spatial.Create.BoundingBox3D(x, y, z), pointCount, seed, tolerance);

        }
    }
}
