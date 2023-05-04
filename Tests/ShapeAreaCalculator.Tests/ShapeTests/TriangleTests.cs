namespace ShapeAreaCalculator.Tests.ShapeTests;

using System;
using FluentAssertions;
using ShapeAreaCalculator.Shapes;
using Xunit;

public class TriangleTests
{
    [Fact]
    public void ShouldCalculateTriangleArea()
    {
        var sut = new Triangle(
            firstSideLength: 3,
            secondSideLength: 4,
            thirdSideLength: 5);

        var result = sut.CalculateArea();

        result
            .Should()
            .Be(6);
    }

    [Fact]
    public void TriangleShouldBeRightAngle()
    {
        var triangle = new Triangle(
            firstSideLength: 3,
            secondSideLength: 5,
            thirdSideLength: 4);

        triangle.IsRightAngle()
            .Should()
            .BeTrue();
    }

    [Fact]
    public void TriangleShouldNotBeRightAngle()
    {
        var triangle = new Triangle(
            firstSideLength: 7,
            secondSideLength: 5,
            thirdSideLength: 4);

        triangle.IsRightAngle()
            .Should()
            .BeFalse();
    }

    [Fact]
    public void ShouldThrowExceptionOnInvalidTriangleParameters()
    {
        var creatingTriangleFunc = () =>
            new Triangle(
                firstSideLength: 3,
                secondSideLength: 2,
                thirdSideLength: 7);

        creatingTriangleFunc
            .Should()
            .Throw<ArgumentException>();
    }
}