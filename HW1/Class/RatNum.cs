

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
        if (d == 0)
            throw new ArgumentException("Знаменатель не должен быть равен 0."); // мы же пока в высшую математику не лезем.

        this._N = n;
        this._D = d;
    }

    /// <summary>
    /// Перевод дроби в десятичный вид.
    /// </summary>
    /// <param name="N">числитель</param>
    /// <param name="D">знаменатель</param>
    /// <returns></returns>
    private static double FractToDeg(RatNum X)
    {
        return (double)(X.N/X.D);
    }
    //Булевы
    //Скорее всего это варварские методы, это я про промежуточный перевод в десятичную дробь, но я так вижу.
    public static bool operator == (RatNum r1, RatNum r2)
    {
        return (r1.N/r1.D == r2.N / r2.D);
    }

    public static bool Equals(RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D == r2.N / r2.D);
    }

    public static bool operator !=(RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D != r2.N / r2.D);
    }

    public static bool operator > (RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D > r2.N / r2.D);
    }
    public static bool operator <(RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D < r2.N / r2.D);
    }
    public static bool operator <= (RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D <= r2.N / r2.D);
    }
    public static bool operator >=(RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D >= r2.N / r2.D);
    }


    //Арифметика
    public static RatNum operator + (RatNum r1 , RatNum r2)
    {
        return new RatNum((r1.N * r2.D)+ (r2.N * r1.D), r1.D * r2.D);
    }
    public static RatNum operator - (RatNum r1, RatNum r2)
    {
        return new RatNum((r1.N * r2.D) - (r2.N * r1.D), r1.D * r2.D);
    }
    public static RatNum operator * (RatNum r1, RatNum r2)
    {
        return new RatNum(r1.N * r2.N, r1.D + r2.D);
    }
    public static RatNum operator / (RatNum r1, RatNum r2)
    {
        return new RatNum(r1.N * r2.D, r1.D * r2.N);
    }



}
