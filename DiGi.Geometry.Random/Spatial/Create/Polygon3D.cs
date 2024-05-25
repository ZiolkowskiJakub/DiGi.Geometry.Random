using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Spatial.Classes;
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

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon3D(boundingBox3D, pointCount, random, tolerance);
        }

        public static Polygon3D Polygon3D(BoundingBox3D boundingBox3D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            Plane plane = Plane(boundingBox3D, random, tolerance);
            if (plane == null)
            {
                return null;
            }

            PlanarIntersectionResult planarIntersectionResult = Spatial.Create.PlanarIntersectionResult(plane, boundingBox3D, tolerance);
            if (planarIntersectionResult == null || !planarIntersectionResult.Intersect)
            {
                return null;
            }

            IPolygonal2D polygonal2D = planarIntersectionResult.GetGeometry2Ds<IPolygonal2D>()?.FirstOrDefault();
            if (polygonal2D == null)
            {
                return null;
            }

            Polygon2D polygon2D = Planar.Random.Create.Polygon2D(polygonal2D, pointCount, random, tolerance);
            if (polygon2D == null)
            {
                return null;
            }

            return plane.Convert(polygon2D);
        }

        public static Polygon3D Polygon3D(Range<double> x, Range<double> y, Range<double> z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polygon3D(x, y, z, pointCount, random, tolerance);

        }

        public static Polygon3D Polygon3D(Range<double> x, Range<double> y, Range<double> z, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return Polygon3D(Spatial.Create.BoundingBox3D(x, y, z), pointCount, random, tolerance);

        }
    }
}
