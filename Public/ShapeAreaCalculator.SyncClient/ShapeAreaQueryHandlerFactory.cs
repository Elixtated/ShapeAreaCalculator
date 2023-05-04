namespace ShapeAreaCalculator.SyncClient;

using ShapeAreaCalculator.UseCases;

public static class ShapeAreaQueryHandlerFactory
{
    public static ShapeAreaQuery.IHandler Create()
    {
        return new ShapeAreaQueryHandler();
    }
}