namespace ShapeAreaCalculator.Tests.QueryHandlersTests;

using FluentAssertions;
using ShapeAreaCalculator.Shapes;
using ShapeAreaCalculator.SyncClient;
using Xunit;

public class ShapeAreaCalculatorTests
{
    [Fact]
    public void ShouldCalculateCircleArea()
    {
        var sut = ShapeAreaQueryHandlerFactory.Create();

        var circle = new Circle(
            radius: 5);

        var result = sut.Handle(
            new ShapeAreaQuery(
                shape: circle));

        var expectedArea = circle.CalculateArea();

        result
            .Should()
            .Be(expectedArea);
    }

    [Fact]
    public void ShouldCalculateTriangleArea()
    {
        var sut = ShapeAreaQueryHandlerFactory.Create();

        var triangle = new Triangle(
            firstSideLength: 3,
            secondSideLength: 4,
            thirdSideLength: 5);

        var result = sut.Handle(
            new ShapeAreaQuery(
                shape: triangle));

        var expectedArea = triangle.CalculateArea();

        result
            .Should()
            .Be(expectedArea);
    }
}