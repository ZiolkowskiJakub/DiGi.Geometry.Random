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

            System.Random random = DiGi.Core.Create.Random(seed);

            return Plane(boundingBox3D, random, tolerance);
        }

        public static Plane Plane(BoundingBox3D boundingBox3D, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            Point3D point3D = Point3D(boundingBox3D, random, tolerance);
            if (point3D == null)
            {
                return null;
            }

            Vector3D vector3D = Vector3D(random, tolerance);
            if (vector3D == null)
            {
                return null;
            }

            return new Plane(point3D, vector3D);
        }

        public static Plane Plane(Range<double> x, Range<double> y, Range<double> z, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Plane(x, y, z, random, tolerance);

        }

        public static Plane Plane(Range<double> x, Range<double> y, Range<double> z, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            Point3D point3D = Point3D(x, y, z, random, tolerance);
            if (point3D == null)
            {
                return null;
            }

            Vector3D vector3D = Vector3D(random, tolerance);
            if (vector3D == null)
            {
                return null;
            }


            return new Plane(point3D, vector3D);

        }
    }
}
