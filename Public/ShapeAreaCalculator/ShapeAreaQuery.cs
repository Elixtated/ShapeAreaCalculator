namespace ShapeAreaCalculator;

public class ShapeAreaQuery
{
    public ShapeAreaQuery(
        IShape shape)
    {
        this.Shape = shape;
    }

    public interface IHandler
    {
        double Handle(
            ShapeAreaQuery shapeAreaQuery);
    }

    public IShape Shape { get; }
}