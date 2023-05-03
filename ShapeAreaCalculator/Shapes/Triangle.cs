namespace ShapeAreaCalculator.Shapes;

using System;
using System.Linq;

public class Triangle : IShape
{
    private readonly double firstSideLength;
    private readonly double secondSideLength;
    private readonly double thirdSideLength;

    public Triangle(
        double firstSideLength,
        double secondSideLength,
        double thirdSideLength)
    {
        if (firstSideLength + secondSideLength < thirdSideLength ||
            secondSideLength + thirdSideLength < firstSideLength ||
            firstSideLength + thirdSideLength < secondSideLength)
        {
            throw new ArgumentException("Provided sides do not form a triangle");
        }

        this.firstSideLength = firstSideLength;
        this.secondSideLength = secondSideLength;
        this.thirdSideLength = thirdSideLength;
    }

    public double CalculateArea()
    {
        var halfPerimeter =
            (this.firstSideLength + this.secondSideLength + this.thirdSideLength) / 2;

        var oppositeSideCoefficient = halfPerimeter - this.firstSideLength;
        var hypotenuseSideCoefficient = halfPerimeter - this.secondSideLength;
        var adjacentSideCoefficient = halfPerimeter - this.thirdSideLength;

        var area = Math.Sqrt(
            halfPerimeter * oppositeSideCoefficient * hypotenuseSideCoefficient * adjacentSideCoefficient);

        return area;
    }

    public bool IsRightAngle()
    {
        var longestSide = new[]
                { this.thirdSideLength, this.secondSideLength, this.firstSideLength, }
            .Max();

        var longestSideSquare = longestSide * longestSide;

        return
            Math.Abs(longestSideSquare + longestSideSquare - (this.thirdSideLength * this.thirdSideLength +
                this.secondSideLength * this.secondSideLength + this.firstSideLength *
                this.firstSideLength)) < Constants.ComparisonTolerance;
    }
}