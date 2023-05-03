namespace ShapeAreaCalculator.Tests;

using FluentAssertions;
using global::ShapeAreaCalculator.Shapes;
using Xunit;

public class ShapeAreaCalculatorTests
{
    [Fact]
    public void ShouldCalculateCircleArea()
    {
        const int radius = 5;
        var circle = new Circle(
            radius: radius);

        var result = ShapeAreaCalculator.CalculateArea(
            shape: circle);

        result
            .Should()
            .Be(78.53981633974483);
    }

    [Fact]
    public void ShouldCalculateTriangleArea()
    {
        var triangle = new Triangle(
            firstSideLength: 3,
            secondSideLength: 4,
            thirdSideLength: 5);

        var result = ShapeAreaCalculator.CalculateArea(
            shape: triangle);

        result
            .Should()
            .Be(6);
    }
}