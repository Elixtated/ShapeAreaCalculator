namespace ShapeAreaCalculator.Tests.ShapeTests;

using System;
using FluentAssertions;
using ShapeAreaCalculator.Shapes;
using Xunit;

public class CircleTests
{
    [Fact]
    public void ShouldThrowExceptionOnInvalidTriangleParameters()
    {
        var creatingCircleFunc = () =>
            new Circle(
                radius: 0);

        creatingCircleFunc
            .Should()
            .Throw<ArgumentException>();
    }

    [Fact]
    public void ShouldCalculateCircleArea()
    {
        var sut = new Circle(
            radius: 5);

        var result = sut.CalculateArea();

        result
            .Should()
            .Be(78.53981633974483);
    }
}