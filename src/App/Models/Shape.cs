using System.Text.Json.Serialization;

namespace App.Models;

[JsonPolymorphic(UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization)]
[JsonDerivedType(typeof(Circle), nameof(Circle))]
[JsonDerivedType(typeof(Square), nameof(Square))]
[JsonDerivedType(typeof(Rectangle), nameof(Rectangle))]
public abstract record Shape
{
    public abstract double ComputeArea();
}