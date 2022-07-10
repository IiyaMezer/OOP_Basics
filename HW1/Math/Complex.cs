namespace HW_5.Math;

public class Complex
{
    private double _Re;
    private double _Im;

    public double Re
    {
        get => _Re;
        set => _Re = value;
    }
    public double Im
    {
        get => _Im;
        set => _Im = value;
    }

    public Complex(double Re, double Im)
    {
        this._Re = Re;
        this._Im = Im;
    }

    public override string ToString()
    {
        return Re + "+" +"i"+ Im;
    }
}
