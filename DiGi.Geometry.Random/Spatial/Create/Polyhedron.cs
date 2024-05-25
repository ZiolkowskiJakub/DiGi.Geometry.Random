using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using System.Collections.Generic;

namespace DiGi.Geometry.Spatial.Random
{
    public static partial class Create
    {
        public static Polyhedron Polyhedron(BoundingBox3D boundingBox3D, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null)
            {
                return null;
            }

            System.Random random = DiGi.Core.Create.Random(seed);

            return Polyhedron(boundingBox3D, pointCount, random, tolerance); 

        }

        public static Polyhedron Polyhedron(BoundingBox3D boundingBox3D, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (boundingBox3D == null || random == null)
            {
                return null;
            }

            PolygonalFace3D polygonalFace3D = PolygonalFace3D(boundingBox3D, pointCount, random, tolerance);
            if (polygonalFace3D == null)
            {
                return null;
            }

            Plane plane = polygonalFace3D.Plane;
            if (plane == null)
            {
                return null;
            }

            Vector3D normal = plane.Normal;
            if (normal == null)
            {
                return null;
            }

            double length = double.MaxValue;
            foreach (IPolygonal3D edge in polygonalFace3D.Edges)
            {
                if (edge == null)
                {
                    continue;
                }

                List<Point3D> point3Ds = edge.GetPoints();
                if (point3Ds == null || point3Ds.Count == 0)
                {
                    continue;
                }


                for (int i = 0; i < point3Ds.Count; i++)
                {
                    IntersectionResult3D intersectionResult3D = Spatial.Create.IntersectionResult3D(boundingBox3D, point3Ds[i], normal, tolerance);
                    if (intersectionResult3D == null || !intersectionResult3D.Intersect)
                    {
                        continue;
                    }

                    foreach (IGeometry3D geometry3D in intersectionResult3D.GetGeometry3Ds<IGeometry3D>())
                    {
                        double length_Temp = double.NaN;
                        if (geometry3D is Point3D)
                        {
                            length_Temp = point3Ds[i].Distance((Point3D)geometry3D);
                        }
                        else if (geometry3D is Segment3D)
                        {
                            length_Temp = ((Segment3D)geometry3D).Length;

                        }

                        if (!double.IsNaN(length_Temp) && length_Temp < length)
                        {
                            length = length_Temp;
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

        public static Polyhedron Polyhedron(Range<double> x, Range<double> y, Range<double> z, int pointCount, int seed = -1, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null)
            {
                return null;
            }


            System.Random random = DiGi.Core.Create.Random(seed);

            return Polyhedron(x, y , z, pointCount, random, tolerance);
        }

        public static Polyhedron Polyhedron(Range<double> x, Range<double> y, Range<double> z, int pointCount, System.Random random, double tolerance = DiGi.Core.Constans.Tolerance.MacroDistance)
        {
            if (x == null || y == null || z == null || random == null)
            {
                return null;
            }

            return Polyhedron(Spatial.Create.BoundingBox3D(x, y, z), pointCount, random, tolerance);
        }
    }
}
