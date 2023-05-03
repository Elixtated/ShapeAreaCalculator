namespace ShapeAreaCalculator.Tests;

using System;
using FluentAssertions;
using global::ShapeAreaCalculator.Shapes;
using Xunit;

public class TriangleTests
{
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