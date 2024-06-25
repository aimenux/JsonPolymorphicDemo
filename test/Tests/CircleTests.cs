using System.Text.Json;
using App.Models;
using AutoFixture;
using FluentAssertions;

namespace Tests;

public class CircleTests
{
    [Fact]
    public void Should_Serialize_Circles()
    {
        // arrange
        Shape shape = new Fixture().Create<Circle>();

        // act
        var json = JsonSerializer.Serialize(shape);

        // assert
        json.Should().NotBeNullOrEmpty();
        json.Should().Contain("Circle");
        json.Should().Contain("Radius");
    }
    
    [Fact]
    public void Should_Deserialize_Circles()
    {
        // arrange
        Shape shape = new Fixture().Create<Circle>();
        var json = JsonSerializer.Serialize(shape);

        // act
        var circle = JsonSerializer.Deserialize<Shape>(json);

        // assert
        circle.Should().NotBeNull();
        circle.Should().BeOfType<Circle>();
    }
}