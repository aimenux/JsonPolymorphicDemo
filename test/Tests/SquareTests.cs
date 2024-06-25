using System.Text.Json;
using App.Models;
using AutoFixture;
using FluentAssertions;

namespace Tests;

public class SquareTests
{
    [Fact]
    public void Should_Serialize_Squares()
    {
        // arrange
        Shape shape = new Fixture().Create<Square>();

        // act
        var json = JsonSerializer.Serialize(shape);

        // assert
        json.Should().NotBeNullOrEmpty();
        json.Should().Contain("Square");
        json.Should().Contain("Side");
    }
    
    [Fact]
    public void Should_Deserialize_Squares()
    {
        // arrange
        Shape shape = new Fixture().Create<Square>();
        var json = JsonSerializer.Serialize(shape);

        // act
        var square = JsonSerializer.Deserialize<Shape>(json);

        // assert
        square.Should().NotBeNull();
        square.Should().BeOfType<Square>();
    }
}