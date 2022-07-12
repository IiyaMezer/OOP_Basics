namespace Math;

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

    public static Complex operator +(Complex C1, Complex C2)
    {
        return new Complex(C1.Re + C2.Re, C1.Im + C2.Im);
    }
    public static Complex operator -(Complex C1, Complex C2)
    {
        return new Complex(C1.Re - C2.Re, C1.Im - C2.Im);
    }
    public static Complex operator *(Complex C1, Complex C2)
    {
        return new Complex((C1.Re*C2.Re)-(C1.Im * C2.Im), (C1.Im * C2.Re) + (C1.Re * C2.Im));
    }

    public bool Equals(Complex c1)
    {
        return (c1.Re == Re && c1.Im==Im); ;
    }

    public static bool operator == (Complex C1, Complex C2)
    {
        return C1.Re == C2.Re && C1.Im == C2.Im;
    }
    public static bool operator !=(Complex C1, Complex C2)
    {
        return C1.Re != C2.Re && C1.Im != C2.Im;
    }

    public override string ToString()
    {
        return $"{Re}+{Im}i";
    }
}
