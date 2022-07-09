

namespace HW_5.Class;

public class RatNum
{
    private int _N; //числитель
    private int _D; //знаменатель

    public int N
    {
        get => _N;
        set => _N = value;
    }

    public int D
    {
        get => _D;
        set => _D = value;
    }

    public RatNum (int n, int d)
    {
        this._N = n;
        this._D = d;
    }

    /// <summary>
    /// Переаод дроби в десятичный вид
    /// </summary>
    /// <param name="N">числитель</param>
    /// <param name="D">знаменатель</param>
    /// <returns></returns>
    private double FractToDeg(int N, int D)
    {
        return (double)(N/D);
    }




}
