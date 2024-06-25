namespace App.Models;

public record Circle(double Radius) : Shape
{
    public override double ComputeArea()
    {
        return Math.PI * Radius * Radius;
    }
}