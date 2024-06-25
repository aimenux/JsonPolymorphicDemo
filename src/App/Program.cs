using System.Text.Json;
using App.Models;

var shapes = new Shape[]
{
    new Circle(5),
    new Square(6),
    new Rectangle(5, 6)
};

foreach (var shape in shapes)
{
    var json = JsonSerializer.Serialize(shape);
    Console.WriteLine(json);
}
