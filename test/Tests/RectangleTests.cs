using System.Text.Json;
using App.Models;
using AutoFixture;
using FluentAssertions;

namespace Tests;

public class RectangleTests
{
    [Fact]
    public void Should_Serialize_Rectangles()
    {
        // arrange
        Shape shape = new Fixture().Create<Rectangle>();

        // act
        var json = JsonSerializer.Serialize(shape);

        // assert
        json.Should().NotBeNullOrEmpty();
        json.Should().Contain("Rectangle");
        json.Should().Contain("Width");
        json.Should().Contain("Height");
    }
    
    [Fact]
    public void Should_Deserialize_Rectangles()
    {
        // arrange
        Shape shape = new Fixture().Create<Rectangle>();
        var json = JsonSerializer.Serialize(shape);

        // act
        var square = JsonSerializer.Deserialize<Rectangle>(json);

        // assert
        square.Should().NotBeNull();
        square.Should().BeOfType<Rectangle>();
    }
}