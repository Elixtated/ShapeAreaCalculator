namespace ShapeAreaCalculator.UseCases;

internal class ShapeAreaQueryHandler : ShapeAreaQuery.IHandler
{
    public double Handle(
        ShapeAreaQuery shapeAreaQuery)
    {
        return shapeAreaQuery.Shape.CalculateArea();
    }
}