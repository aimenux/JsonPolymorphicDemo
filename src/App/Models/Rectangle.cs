namespace App.Models;

public record Rectangle(double Width, double Height) : Shape
{
    public override double ComputeArea()
    {
        return Width * Height;
    }
}