namespace ShapeAreaCalculator.Shapes;

using System;
using System.Linq;

public class Triangle : IShape
{
    private const double ComparisonTolerance = 1e-7;

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

        var firstSideCoefficient = halfPerimeter - this.firstSideLength;
        var secondSideCoefficient = halfPerimeter - this.secondSideLength;
        var thirdSideCoefficient = halfPerimeter - this.thirdSideLength;

        var area = Math.Sqrt(
            halfPerimeter * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);

        return area;
    }

    public bool IsRightAngle()
    {
        var longestSide = new[]
                { this.thirdSideLength, this.secondSideLength, this.firstSideLength, }
            .Max();

        var longestSideSquare = longestSide * longestSide;

        return
            Math.Abs(
                longestSideSquare + longestSideSquare
                - (this.firstSideLength * this.firstSideLength +
                    this.secondSideLength * this.secondSideLength +
                    this.thirdSideLength * this.thirdSideLength)) < ComparisonTolerance;
    }
}