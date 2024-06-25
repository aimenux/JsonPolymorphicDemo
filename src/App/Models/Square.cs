namespace App.Models;

public record Square(double Side) : Shape
{
    public override double ComputeArea()
    {
        return Side * Side;
    }
}