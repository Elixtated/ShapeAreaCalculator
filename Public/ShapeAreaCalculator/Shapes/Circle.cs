namespace ShapeAreaCalculator.Shapes;

using System;

public class Circle : IShape
{
    private readonly double radius;

    public Circle(
        double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException("The radius cannot be negative");
        }

        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * this.radius * this.radius;
    }
}