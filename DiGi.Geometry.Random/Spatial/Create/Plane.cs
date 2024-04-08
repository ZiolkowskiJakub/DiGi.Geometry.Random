using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static Plane Plane(BoundingBox3D boundingBox3D, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            Point3D point3D = Point3D(boundingBox3D, seed, tolerance);
            if (point3D == null)
            {
                return null;
            }

            Vector3D vector3D = Vector3D(seed, tolerance);
            if (vector3D == null)
            {
                return null;
            }


            return new Plane(point3D, vector3D);
        }

        public static Plane plane(Range<double> x, Range<double> y, Range<double> z, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            Point3D point3D = Point3D(x, y, z, seed, tolerance);
            if (point3D == null)
            {
                return null;
            }

            Vector3D vector3D = Vector3D(seed, tolerance);
            if (vector3D == null)
            {
                return null;
            }


            return new Plane(point3D, vector3D);

        }
    }
}
