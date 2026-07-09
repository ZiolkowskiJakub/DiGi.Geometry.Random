#### [DiGi\.Geometry\.Random](DiGi.Geometry.Random.Overview.md 'DiGi\.Geometry\.Random\.Overview')

## DiGi\.Geometry\.Spatial\.Random Namespace
### Classes

<a name='DiGi.Geometry.Spatial.Random.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double)'></a>

## Create\.Plane\(Range\<double\>, Range\<double\>, Range\<double\>, int, double\) Method

Generates a [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') based on the specified coordinate ranges\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of the X\-axis as a [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of the Y\-axis as a [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range of the Z\-axis as a [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used to seed the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') specifying the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance if [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Plane\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Plane\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.y'), and [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.Plane\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.z') are not null; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double)'></a>

## Create\.Plane\(Range\<double\>, Range\<double\>, Range\<double\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') based on the provided coordinate ranges, a random number generator, and a tolerance value\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the X\-coordinate of the point on the plane\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the Y\-coordinate of the point on the plane\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the Z\-coordinate of the point on the plane\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values for the point and vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance if a valid [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') and [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') can be generated; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double)'></a>

## Create\.Plane\(BoundingBox3D, int, double\) Method

Generates a [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') based on the provided [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D'), using a random seed and a specified tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') used to define the spatial constraints for the plane generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used as the seed for the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') instance if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Plane\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, double\)\.boundingBox3D') is not null; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double)'></a>

## Create\.Plane\(BoundingBox3D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') based on the provided [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D'), [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance, and tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Plane? Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') used to constrain the random point generation for the plane\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values\.

<a name='DiGi.Geometry.Spatial.Random.Create.Plane(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used during the generation process, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane')  
A randomly generated [DiGi\.Geometry\.Spatial\.Classes\.Plane](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.plane 'DiGi\.Geometry\.Spatial\.Classes\.Plane') if successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double)'></a>

## Create\.Point3D\(Range\<double\>, Range\<double\>, Range\<double\>, int, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') within the specified coordinate ranges\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Point3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the X\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the Y\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the Z\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used to seed the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') specifying the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance if all provided ranges are non\-null; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double)'></a>

## Create\.Point3D\(Range\<double\>, Range\<double\>, Range\<double\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') based on the specified coordinate ranges and tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Point3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the X\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Y\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Z\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') if [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.y'), [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.z'), and [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.random') are not null; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double)'></a>

## Create\.Point3D\(BoundingBox3D, int, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the boundaries for generating the point\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used to seed the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') located within the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, double\)\.boundingBox3D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, double\)\.boundingBox3D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double)'></a>

## Create\.Point3D\(BoundingBox3D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for the point generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random coordinates\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A randomly generated [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') within the boundaries of the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, System\.Random, double\)\.boundingBox3D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, System\.Random, double\)\.boundingBox3D'), [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, System\.Random, double\)\.random'), or the bounding box's minimum or maximum points are null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,int,double)'></a>

## Create\.Point3D\(Polygon3D, int, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') using a provided seed and tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D? polygon3D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,int,double).polygon3D'></a>

`polygon3D` [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') from which to generate the point\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used as the seed for the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') located within the [polygon3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,int,double).polygon3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.Polygon3D, int, double\)\.polygon3D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [polygon3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,int,double).polygon3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.Polygon3D, int, double\)\.polygon3D') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,System.Random,double)'></a>

## Create\.Point3D\(Polygon3D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') within the boundaries of the specified [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D? polygon3D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,System.Random,double).polygon3D'></a>

`polygon3D` [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')

The [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance used as the boundary for generating the point\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random coordinates\.

<a name='DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') instance representing a random point within the [polygon3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,System.Random,double).polygon3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.Polygon3D, System\.Random, double\)\.polygon3D'), or `null` if the [polygon3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Point3D(DiGi.Geometry.Spatial.Classes.Polygon3D,System.Random,double).polygon3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Point3D\(DiGi\.Geometry\.Spatial\.Classes\.Polygon3D, System\.Random, double\)\.polygon3D') is null, its associated plane is not defined, or a valid 2D point cannot be generated\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double)'></a>

## Create\.Polygon3D\(Range\<double\>, Range\<double\>, Range\<double\>, int, int, double\) Method

Generates a [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') within the specified spatial ranges using a specified number of points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries along the X\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries along the Y\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries along the Z\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer number of points to generate for the polygon\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer seed value used for the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double precision tolerance used for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance if the [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.y'), and [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.z') ranges are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double)'></a>

## Create\.Polygon3D\(Range\<double\>, Range\<double\>, Range\<double\>, int, Random, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') within a three\-dimensional space defined by the provided coordinate ranges\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int pointCount, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent along the X\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent along the Y\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent along the Z\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to be generated for the [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

An instance of [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') used for random point generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double precision tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') if the [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.y'), [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.z'), and [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.random') parameters are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double)'></a>

## Create\.Polygon3D\(BoundingBox3D, int, int, double\) Method

Generates a [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for the polygon generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') specifying the number of vertices to be generated for the [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used as the seed for the random number generator; a value of \-1 indicates a non\-deterministic seed\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') specifying the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') generated within the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, int, double\)\.boundingBox3D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polygon3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, int, double\)\.boundingBox3D') is null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double)'></a>

## Create\.Polygon3D\(BoundingBox3D, int, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polygon3D? Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for the polygon generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of vertices to be generated for the resulting polygon\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to ensure randomness in plane selection and point placement\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polygon3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value specifying the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polygon3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygon3d 'DiGi\.Geometry\.Spatial\.Classes\.Polygon3D') instance if a valid polygon could be generated; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double)'></a>

## Create\.PolygonalFace3D\(Range\<double\>, Range\<double\>, Range\<double\>, int, int, double\) Method

Generates a [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') within the specified spatial ranges using a set number of points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the X\-axis coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Y\-axis coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Z\-axis coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to be generated for the polygonal face\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value used for the random number generator\. A value of \-1 typically indicates a default or random seed\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The geometric tolerance used for operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance if the [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.y'), and [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.z') ranges are provided; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double)'></a>

## Create\.PolygonalFace3D\(Range\<double\>, Range\<double\>, Range\<double\>, int, Random, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') based on the specified X, Y, and Z ranges\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the X\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the Y\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the Z\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer number of points to generate for the polygonal face\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for randomizing point positions\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value specifying the tolerance for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') if [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.y'), [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.z'), and [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.random') are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double)'></a>

## Create\.PolygonalFace3D\(BoundingBox3D, int, int, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') using a random seed and tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial bounds for the face generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') number of points to be used in the creation of the polygonal face\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') seed value for the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance'), used for geometric calculations\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.PolygonalFace3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, int, double\)\.boundingBox3D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double)'></a>

## Create\.PolygonalFace3D\(BoundingBox3D, int, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') within the specified bounding box\.

```csharp
public static DiGi.Geometry.Spatial.Classes.PolygonalFace3D? PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for generating the face\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') number of points to be used in the generation of the polygons\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for stochastic generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.PolygonalFace3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')  
A randomly generated [DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D') instance if the generation is successful; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double)'></a>

## Create\.Polyhedron\(Range\<double\>, Range\<double\>, Range\<double\>, int, int, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') based on the specified spatial ranges and point count\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the X\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the Y\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the Z\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to generate for the construction of the [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value used for the random number generator; a value of \-1 indicates a random seed\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The geometric tolerance used during creation, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') instance if [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polyhedron\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polyhedron\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.y'), and [z](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).z 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polyhedron\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int, double\)\.z') are all provided; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double)'></a>

## Create\.Polyhedron\(Range\<double\>, Range\<double\>, Range\<double\>, int, Random, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') within a three\-dimensional space defined by the specified spatial ranges\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int pointCount, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') defining the extent along the X\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') defining the extent along the Y\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') defining the extent along the Z\-axis\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to be used in the generation of the [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

An instance of [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') used for random point distribution\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') if the spatial ranges and [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polyhedron\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random, double\)\.random') are not null; otherwise, null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double)'></a>

## Create\.Polyhedron\(BoundingBox3D, int, int, double\) Method

Creates a [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') using a random distribution of points\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for the polyhedron generation\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to be used in the creation of the polyhedron\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') seed value for the random number generator; a value of \-1 indicates a non\-deterministic seed\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance used for geometric operations, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') generated within the specified boundaries, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Polyhedron\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, int, double\)\.boundingBox3D') is null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double)'></a>

## Create\.Polyhedron\(BoundingBox3D, int, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') based on a provided [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D'), using a randomly generated polygonal face and an extrusion length derived from the bounding box constraints\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Polyhedron? Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for the generation process\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') specifying the number of points used to create the base polygonal face\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

A [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to randomize the face generation and the final extrusion length\.

<a name='DiGi.Geometry.Spatial.Random.Create.Polyhedron(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron')  
A [DiGi\.Geometry\.Spatial\.Classes\.Polyhedron](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polyhedron 'DiGi\.Geometry\.Spatial\.Classes\.Polyhedron') if the object was successfully created; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector2D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double)'></a>

## Create\.Vector2D\(BoundingBox3D, int, double\) Method

Generates a [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') based on the provided [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D'), utilizing a random seed and a specific tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector2D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Vector2D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') used as the basis for generating the vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector2D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used to initialize the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector2D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector2D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,int,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector2D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, int, double\)\.boundingBox3D') is not null; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double)'></a>

## Create\.Vector3D\(Range\<double\>, Range\<double\>, Range\<double\>, int, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') within the specified ranges for each axis\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range for the X\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range for the Y\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The range for the Z\-coordinate\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used to seed the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') if both [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.x') and [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.y') are not null; otherwise, `null`\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double)'></a>

## Create\.Vector3D\(Range\<double\>, Range\<double\>, Range\<double\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') within the specified ranges, ensuring that the resulting vector's length is at least the specified tolerance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector3D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<double>? z, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the X component of the vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Y component of the vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).z'></a>

`z` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Z component of the vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum length threshold that the resulting [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') must meet; defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') that satisfies the length requirement, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [x](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.x'), [y](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.y'), or [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.random') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double)'></a>

## Create\.Vector3D\(BoundingBox3D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') within the specified [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D? boundingBox3D, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D'></a>

`boundingBox3D` [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D')

The [DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.boundingbox3d 'DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D') that defines the spatial boundaries for generating the random vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to produce the random coordinates\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A randomly generated [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') within the specified [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, System\.Random, double\)\.boundingBox3D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [boundingBox3D](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).boundingBox3D 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, System\.Random, double\)\.boundingBox3D'), [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(DiGi.Geometry.Spatial.Classes.BoundingBox3D,System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(DiGi\.Geometry\.Spatial\.Classes\.BoundingBox3D, System\.Random, double\)\.random'), or any of the bounding box's boundary points are null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(int,double)'></a>

## Create\.Vector3D\(int, double\) Method

Generates a random [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') using the specified [seed](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(int,double).seed 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(int, double\)\.seed') and [tolerance](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(int,double).tolerance 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(int, double\)\.tolerance')\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector3D(int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') seed used to initialize the random number generator\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance for the operation, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A nullable [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing the generated random vector\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(System.Random,double)'></a>

## Create\.Vector3D\(Random, double\) Method

Generates a random unit [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') by creating a random vector and ensuring its length exceeds the specified [tolerance](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(System.Random,double).tolerance 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(System\.Random, double\)\.tolerance') before normalization\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? Vector3D(System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate the random components of the vector\. If this [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') is null, the method returns null\.

<a name='DiGi.Geometry.Spatial.Random.Create.Vector3D(System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value specifying the minimum length threshold that the generated vector must meet before it can be normalized\. The default value is [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A unit [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representing a random direction, or null if the [random](DiGi.Geometry.Spatial.Random.md#DiGi.Geometry.Spatial.Random.Create.Vector3D(System.Random,double).random 'DiGi\.Geometry\.Spatial\.Random\.Create\.Vector3D\(System\.Random, double\)\.random') instance is null\.