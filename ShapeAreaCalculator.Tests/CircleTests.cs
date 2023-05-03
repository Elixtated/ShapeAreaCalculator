namespace ShapeAreaCalculator.Tests;

using System;
using FluentAssertions;
using global::ShapeAreaCalculator.Shapes;
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
}