namespace Geometry;

public class Circle : Point
{
    private  double _radius;

    public double Radius
    {
        get => _radius;
        set => _radius = value;//менять размер фигур в процессе не запрещено.
    }
    public virtual double Square()
    {
        return 2 * Math.PI * Radius;
    }
}
