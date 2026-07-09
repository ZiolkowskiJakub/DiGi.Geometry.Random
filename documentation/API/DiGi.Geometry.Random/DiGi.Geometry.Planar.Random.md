#### [DiGi\.Geometry\.Random](DiGi.Geometry.Random.Overview.md 'DiGi\.Geometry\.Random\.Overview')

## DiGi\.Geometry\.Planar\.Random Namespace
### Classes

<a name='DiGi.Geometry.Planar.Random.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int)'></a>

## Create\.Point2D\(Range\<double\>, Range\<double\>, int\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') within the specified X and Y coordinate ranges\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int seed=-1);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the X coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the Y coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer seed used to initialize the random number generator\. Defaults to \-1\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') if both [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int\)\.x') and [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int\)\.y') are not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random)'></a>

## Create\.Point2D\(Range\<double\>, Range\<double\>, Random\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') within the specified X and Y ranges using the provided [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, System.Random? random);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values defining the range for the X coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') values defining the range for the Y coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random numbers within the specified ranges\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A new [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') if [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random\)\.x'), [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random\)\.y'), and [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random\)\.random') are not null; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int)'></a>

## Create\.Point2D\(BoundingBox2D, int\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') within the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int seed=-1);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the boundaries for the point generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used as a seed for the random number generator to ensure reproducibility\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') located within the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int\)\.boundingBox2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int\)\.boundingBox2D') or its minimum and maximum corners are null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random)'></a>

## Create\.Point2D\(BoundingBox2D, Random\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') within the boundaries of the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Random? random);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the area from which to generate the point\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate the random coordinates\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') located within the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, System\.Random\)\.boundingBox2D'), or `null` if [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, System\.Random\)\.boundingBox2D') is `null`, [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, System\.Random\)\.random') is `null`, or if the bounding box's minimum or maximum corners are not defined\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double)'></a>

## Create\.Point2D\(PolygonalFace2D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') located within the boundaries of the specified [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D? polygonalFace2D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).polygonalFace2D'></a>

`polygonalFace2D` [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')

The [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') from which to sample a random point\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate the random coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for geometric validation and intersection tests\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') that is inside the [polygonalFace2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).polygonalFace2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D, System\.Random, double\)\.polygonalFace2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [polygonalFace2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).polygonalFace2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D, System\.Random, double\)\.polygonalFace2D') or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D, System\.Random, double\)\.random') are null, or if the face's bounding box dimensions are smaller than the specified [tolerance](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.PolygonalFace2D,System.Random,double).tolerance 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D, System\.Random, double\)\.tolerance')\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double)'></a>

## Create\.Point2D\(Segment2D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') located on the specified [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Geometry.Planar.Classes.Segment2D? segment2D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).segment2D'></a>

`segment2D` [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')

The [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') from which to sample a random point\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate the random coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used to determine if the segment is vertical or horizontal, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A randomly sampled [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') on the [segment2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).segment2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.Segment2D, System\.Random, double\)\.segment2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [segment2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).segment2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.Segment2D, System\.Random, double\)\.segment2D') is null, the [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.Segment2D, System\.Random, double\)\.random') instance is null, or the segment length is smaller than the specified [tolerance](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Classes.Segment2D,System.Random,double).tolerance 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Classes\.Segment2D, System\.Random, double\)\.tolerance')\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,double)'></a>

## Create\.Point2D\(IPolygonal2D, int, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') from the specified [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance to process\. This parameter can be null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used as the seed for the random number generator\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') representing the distance tolerance, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instance if [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2D\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, int, double\)\.polygonal2D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Random,double)'></a>

## Create\.Point2D\(IPolygonal2D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') within the bounds of the specified [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') geometry\.

```csharp
public static DiGi.Geometry.Planar.Classes.Point2D? Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Random,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') geometry used as the sampling area\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')  
A randomly sampled [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') if a point could be determined; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int)'></a>

## Create\.Point2Ds\(Range\<double\>, Range\<double\>, int, int\) Method

Generates a list of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances within the specified X and Y ranges\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int count, int seed=-1);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the bounds for the X coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the bounds for the Y coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances to generate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value used to initialize the random number generator\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if either [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int\)\.x') or [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, int\)\.y') is null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random)'></a>

## Create\.Point2Ds\(Range\<double\>, Range\<double\>, int, Random\) Method

Generates a collection of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects within the specified X and Y ranges\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int count, System.Random random);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the X coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range for the Y coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to attempt to generate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or null if either the [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random\)\.x') or [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, System\.Random\)\.y') range is null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,int)'></a>

## Create\.Point2Ds\(BoundingBox2D, Range\<int\>, int\) Method

Generates a list of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances within the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Core.Classes.Range<int>? count, int seed=-1);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,int).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the boundaries for generating the points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,int).count'></a>

`count` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of integers specifying the number of points to generate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value used to initialize the random number generator\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,int).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, DiGi\.Core\.Classes\.Range\<int\>, int\)\.boundingBox2D') or [count](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,int).count 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, DiGi\.Core\.Classes\.Range\<int\>, int\)\.count') is null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random)'></a>

## Create\.Point2Ds\(BoundingBox2D, Range\<int\>, Random\) Method

Generates a list of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances within the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') based on a quantity randomly selected from the provided [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, DiGi.Core.Classes.Range<int>? count, System.Random random);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the spatial boundaries for generating points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random).count'></a>

`count` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of integers used to determine a random number of points to generate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for random number generation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random\)\.boundingBox2D'), [count](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random).count 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random\)\.count'), or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,DiGi.Core.Classes.Range_int_,System.Random).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random\)\.random') is null, or if the bounding box lacks a minimum or maximum corner\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int)'></a>

## Create\.Point2Ds\(BoundingBox2D, int, int\) Method

Generates a collection of random points within the specified axis\-aligned bounding box\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int count, int seed=-1);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') defining the area from which to generate points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances to create\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value used for the random number generator to ensure reproducibility\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
An array of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects contained within the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, int\)\.boundingBox2D'), or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, int\)\.boundingBox2D') is null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random)'></a>

## Create\.Point2Ds\(BoundingBox2D, int, Random\) Method

Generates a list of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances within the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int count, System.Random? random);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the boundaries for generating points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of random points to generate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to produce the random values\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances, or `null` if the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, System\.Random\)\.boundingBox2D') is null, the [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, System\.Random\)\.random') instance is null, or the bounding box corners are not defined\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double)'></a>

## Create\.Point2Ds\(IPolygonal2D, Range\<int\>, int, double\) Method

Generates a list of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') objects from the specified [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance based on a count range and randomization seed\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, DiGi.Core.Classes.Range<int>? count, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object used to generate points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double).count'></a>

`count` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') values specifying the number of points to be generated\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used as the seed for the random number generator\. Defaults to \-1\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, int, double\)\.polygonal2D') or [count](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,int,double).count 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, int, double\)\.count') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double)'></a>

## Create\.Point2Ds\(IPolygonal2D, Range\<int\>, Random, double\) Method

Generates a list of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances from the specified polygonal object based on a random count within a given range\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, DiGi.Core.Classes.Range<int>? count, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance used as the source for point generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).count'></a>

`count` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of integers from which the number of points to generate is randomly selected\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to perform random sampling\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value for point generation, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random, double\)\.polygonal2D'), [count](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).count 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random, double\)\.count'), or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random, double\)\.random') is null\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double)'></a>

## Create\.Point2Ds\(IPolygonal2D, int, int, double\) Method

Generates a collection of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances within the specified polygonal area\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, int count, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The polygonal object used as the boundary for generating points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances to generate\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The seed value for the random number generator; a value of \-1 indicates that a random seed should be used\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance applied during point generation, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the generated points, or `null` if the [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, int, int, double\)\.polygonal2D') is `null`\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double)'></a>

## Create\.Point2Ds\(IPolygonal2D, int, Random, double\) Method

Generates a list of random [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances based on the provided [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object\.

```csharp
public static System.Collections.Generic.List<DiGi.Geometry.Planar.Classes.Point2D>? Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, int count, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') instance used to generate points\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).count'></a>

`count` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of [DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D') instances to attempt to create\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for random generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Planar\.Classes\.Point2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.point2d 'DiGi\.Geometry\.Planar\.Classes\.Point2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A [System\.Collections\.Generic\.List&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1') containing the successfully generated points; otherwise, `null` if [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, int, System\.Random, double\)\.polygonal2D') or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Point2Ds(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Point2Ds\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, int, System\.Random, double\)\.random') is `null`\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,int,double)'></a>

## Create\.Polygon2D\(Range\<double\>, Range\<double\>, Range\<int\>, int, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') based on specified coordinate and point count ranges\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<int>? pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of double values defining the X\-axis boundaries\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of double values defining the Y\-axis boundaries\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,int,double).pointCount'></a>

`pointCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') of integer values defining the possible number of vertices in the polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An integer seed used to initialize the random number generator\. A value of \-1 indicates a non\-deterministic seed\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A double value representing the macro distance tolerance for geometric operations\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance if both X and Y ranges are provided; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,System.Random,double)'></a>

## Create\.Polygon2D\(Range\<double\>, Range\<double\>, Range\<int\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') within the specified X and Y ranges, with a number of points determined by the provided point count range\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<int>? pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the X\-axis\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the Y\-axis\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,System.Random,double).pointCount'></a>

`pointCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') used to randomly determine the number of vertices in the polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for random generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A randomly generated [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') if both the X and Y ranges are provided; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double)'></a>

## Create\.Polygon2D\(Range\<double\>, Range\<double\>, int, int, double\) Method

Creates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') based on the specified X and Y ranges, point count, seed, and tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the X\-axis coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Y\-axis coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer number of points to generate for the polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer seed used for random point generation; a value of \-1 uses a default random seed\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double precision tolerance for geometric operations, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') if both the X and Y ranges are provided; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double)'></a>

## Create\.Polygon2D\(Range\<double\>, Range\<double\>, int, Random, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') based on the specified X and Y ranges, point count, random number generator, and tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the polygon along the X\-axis\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the extent of the polygon along the Y\-axis\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer number of points to generate for the [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') if the X range, Y range, and random generator are provided; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,double)'></a>

## Create\.Polygon2D\(BoundingBox2D, int, int, double\) Method

Creates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') based on the provided [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') used to derive the polygon vertices\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of points to be included in the resulting [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An optional integer seed for random point generation\. Defaults to \-1\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value representing the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance if the [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') is valid and contains at least three points; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double)'></a>

## Create\.Polygon2D\(BoundingBox2D, int, Random, double\) Method

Creates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') based on the provided axis\-aligned bounding box, point count, and random number generator\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int pointCount, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') used to derive the initial points for the polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer number of points required for the resulting polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for randomization during polygon generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double value specifying the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') if the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, System\.Random, double\)\.boundingBox2D') and [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, System\.Random, double\)\.random') are not null and the [pointCount](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,System.Random,double).pointCount 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, System\.Random, double\)\.pointCount') is at least 3; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double)'></a>

## Create\.Polygon2D\(IPolygonal2D, Range\<int\>, Random, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') from an [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') source using a randomly determined number of points\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, DiGi.Core.Classes.Range<int>? pointCount, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object to be converted into a polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).pointCount'></a>

`pointCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

A nullable [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used as the basis for determining the random number of points\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate the random point count\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance if the operation is successful; otherwise, `null` if [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random, double\)\.polygonal2D'), [pointCount](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).pointCount 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random, double\)\.pointCount'), or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,DiGi.Core.Classes.Range_int_,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, DiGi\.Core\.Classes\.Range\<int\>, System\.Random, double\)\.random') is `null`\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double)'></a>

## Create\.Polygon2D\(IPolygonal2D, int, int, double\) Method

Creates a [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') from the specified [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') source using a defined number of points and an optional random seed\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, int pointCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') source geometry used to generate the polygon\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer number of points to be included in the resulting [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer seed used for random point generation\. A value of \-1 indicates a non\-deterministic seed\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double precision tolerance used for geometric operations, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance if the [polygonal2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).polygonal2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, int, int, double\)\.polygonal2D') is not null and the [pointCount](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,int,double).pointCount 'DiGi\.Geometry\.Planar\.Random\.Create\.Polygon2D\(DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D, int, int, double\)\.pointCount') is 3 or greater; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double)'></a>

## Create\.Polygon2D\(IPolygonal2D, int, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') with a specified number of vertices based on the provided [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') geometry, ensuring that the resulting polygon does not self\-intersect and its segments do not intersect the source geometry\.

```csharp
public static DiGi.Geometry.Planar.Classes.Polygon2D? Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D? polygonal2D, int pointCount, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).polygonal2D'></a>

`polygonal2D` [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D')

The [DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.interfaces.ipolygonal2d 'DiGi\.Geometry\.Planar\.Interfaces\.IPolygonal2D') object used as the basis for sampling random points\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).pointCount'></a>

`pointCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The desired number of vertices \([System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')\) for the generated polygon; must be at least 3\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random point coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Polygon2D(DiGi.Geometry.Planar.Interfaces.IPolygonal2D,int,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance used for proximity and intersection calculations, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Polygon2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygon2d 'DiGi\.Geometry\.Planar\.Classes\.Polygon2D') instance containing the generated vertices if successful; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the inputs are invalid or a valid polygon cannot be constructed\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double)'></a>

## Create\.PolygonalFace2D\(Range\<double\>, Range\<double\>, Range\<int\>, Range\<int\>, int, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') based on the specified coordinate ranges and complexity constraints\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? PolygonalFace2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<int>? pointCount, DiGi.Core.Classes.Range<int>? internalEdgeCount, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range of X\-coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the range of Y\-coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).pointCount'></a>

`pointCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the allowed number of points\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).internalEdgeCount'></a>

`internalEdgeCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the allowed number of internal edges\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') used as a seed for random generation\. A value of \-1 indicates a random seed\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') specifying the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') if [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).x 'DiGi\.Geometry\.Planar\.Random\.Create\.PolygonalFace2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<int\>, DiGi\.Core\.Classes\.Range\<int\>, int, double\)\.x'), [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).y 'DiGi\.Geometry\.Planar\.Random\.Create\.PolygonalFace2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<int\>, DiGi\.Core\.Classes\.Range\<int\>, int, double\)\.y'), [pointCount](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).pointCount 'DiGi\.Geometry\.Planar\.Random\.Create\.PolygonalFace2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<int\>, DiGi\.Core\.Classes\.Range\<int\>, int, double\)\.pointCount'), and [internalEdgeCount](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,int,double).internalEdgeCount 'DiGi\.Geometry\.Planar\.Random\.Create\.PolygonalFace2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<int\>, DiGi\.Core\.Classes\.Range\<int\>, int, double\)\.internalEdgeCount') are provided; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double)'></a>

## Create\.PolygonalFace2D\(Range\<double\>, Range\<double\>, Range\<int\>, Range\<int\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') based on the specified coordinate ranges, point counts, and number of internal edges\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? PolygonalFace2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, DiGi.Core.Classes.Range<int>? pointCount, DiGi.Core.Classes.Range<int>? internalEdgeCount, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') specifying the range for the X\-axis coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') specifying the range for the Y\-axis coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double).pointCount'></a>

`pointCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') specifying the number of points to be used in the polygons\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double).internalEdgeCount'></a>

`internalEdgeCount` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') specifying the number of internal edges \(holes\) to generate within the face\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used for random generation\.

<a name='DiGi.Geometry.Planar.Random.Create.PolygonalFace2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_int_,DiGi.Core.Classes.Range_int_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
A randomly generated [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') if all required parameters are provided; otherwise, `null`\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double)'></a>

## Create\.Segment2D\(Range\<double\>, Range\<double\>, int, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') based on the provided coordinate ranges, a random seed, and a geometric tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Segment2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the X\-axis\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the Y\-axis\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') seed value used to initialize the random number generator\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value used for geometric operations, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') if both [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.x') and [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.y') are not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double)'></a>

## Create\.Segment2D\(Range\<double\>, Range\<double\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') within the specified X and Y ranges, ensuring that the resulting segment's length is at least the specified [tolerance](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).tolerance 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.tolerance')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Segment2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the X coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') defining the boundaries for the Y coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum length required for the generated [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') that satisfies the length requirement, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if any of the required parameters \([x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.x'), [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.y'), or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.random')\) are [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double)'></a>

## Create\.Segment2D\(BoundingBox2D, int, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') within the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') using a provided seed and tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the boundaries for the generated segment\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used to seed the random number generator; a value of \-1 indicates a non\-deterministic seed\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') specifying the geometric tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A new [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') instance if [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, double\)\.boundingBox2D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double)'></a>

## Create\.Segment2D\(BoundingBox2D, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D') within the specified [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Segment2D? Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') that defines the boundaries for generating the segment\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random coordinates\.

<a name='DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D')  
A randomly generated [DiGi\.Geometry\.Planar\.Classes\.Segment2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.segment2d 'DiGi\.Geometry\.Planar\.Classes\.Segment2D'), or `null` if the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, System\.Random, double\)\.boundingBox2D') is `null`, the [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Segment2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Segment2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, System\.Random, double\)\.random') instance is `null`, or the bounding box's minimum or maximum points are null\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double)'></a>

## Create\.Vector2D\(Range\<double\>, Range\<double\>, int, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') within the specified X and Y ranges using a provided seed and distance tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The nullable [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the X\-coordinate\. If [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.x') is null, the method returns null\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The nullable [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Y\-coordinate\. If [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.y') is null, the method returns null\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') seed used to initialize the random number generator\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') if both [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.x') and [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,int,double).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, int, double\)\.y') are non\-null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double)'></a>

## Create\.Vector2D\(Range\<double\>, Range\<double\>, Random, double\) Method

Generates a random [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') within the specified X and Y ranges, ensuring that the length of the resulting vector meets or exceeds the specified tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(DiGi.Core.Classes.Range<double>? x, DiGi.Core.Classes.Range<double>? y, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x'></a>

`x` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the X coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y'></a>

`y` [DiGi\.Core\.Classes\.Range&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1')

The [DiGi\.Core\.Classes\.Range&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.range-1 'DiGi\.Core\.Classes\.Range\`1') for the Y coordinate\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum length threshold that the generated [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') must satisfy\. Defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') that satisfies the tolerance requirement, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if [x](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).x 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.x'), [y](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).y 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.y'), or [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Core.Classes.Range_double_,DiGi.Core.Classes.Range_double_,System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Core\.Classes\.Range\<double\>, DiGi\.Core\.Classes\.Range\<double\>, System\.Random, double\)\.random') is null\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double)'></a>

## Create\.Vector2D\(BoundingBox2D, int, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') based on the provided [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D'), using a random seed and a specified distance tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') used to define the area for vector generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

An [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') value used as a seed for the random number generator\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

A [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') value representing the distance tolerance, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') if the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,int,double).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, int, double\)\.boundingBox2D') is not null; otherwise, null\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double)'></a>

## Create\.Vector2D\(BoundingBox2D, Random, double\) Method

Generates a [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') based on the provided [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D'), using a random generator and a specified tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D? boundingBox2D, System.Random? random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).boundingBox2D'></a>

`boundingBox2D` [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D')

The [DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.boundingbox2d 'DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D') used to define the spatial bounds for vector generation\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values within the ranges of the bounding box\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') if the [boundingBox2D](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(DiGi.Geometry.Planar.Classes.BoundingBox2D,System.Random,double).boundingBox2D 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(DiGi\.Geometry\.Planar\.Classes\.BoundingBox2D, System\.Random, double\)\.boundingBox2D') and its minimum and maximum corners are not null; otherwise, [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null')\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(int,double)'></a>

## Create\.Vector2D\(int, double\) Method

Creates a random [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') based on the specified seed and tolerance\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(int seed=-1, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(int,double).seed'></a>

`seed` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') seed used to initialize the random number generator\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(int,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double') tolerance value, which defaults to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A randomly generated [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') instance\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(System.Random,double)'></a>

## Create\.Vector2D\(Random, double\) Method

Generates a random unit [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') by iteratively creating vectors until the length exceeds the specified [tolerance](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(System.Random,double).tolerance 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(System\.Random, double\)\.tolerance')\.

```csharp
public static DiGi.Geometry.Planar.Classes.Vector2D? Vector2D(System.Random random, double tolerance=0.001);
```
#### Parameters

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(System.Random,double).random'></a>

`random` [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random')

The [System\.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random 'System\.Random') instance used to generate random values\.

<a name='DiGi.Geometry.Planar.Random.Create.Vector2D(System.Random,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The minimum length threshold that a generated vector must exceed before being normalized, defaulting to [DiGi\.Core\.Constants\.Tolerance\.MacroDistance](https://learn.microsoft.com/en-us/dotnet/api/digi.core.constants.tolerance.macrodistance 'DiGi\.Core\.Constants\.Tolerance\.MacroDistance')\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D')  
A unit [DiGi\.Geometry\.Planar\.Classes\.Vector2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.vector2d 'DiGi\.Geometry\.Planar\.Classes\.Vector2D') representing the normalized direction of the generated vector, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the [random](DiGi.Geometry.Planar.Random.md#DiGi.Geometry.Planar.Random.Create.Vector2D(System.Random,double).random 'DiGi\.Geometry\.Planar\.Random\.Create\.Vector2D\(System\.Random, double\)\.random') instance is null\.