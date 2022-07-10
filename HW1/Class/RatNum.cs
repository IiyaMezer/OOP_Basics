

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

    //Булевы
    //Скорее всего это варварские методы, это я про промежуточный перевод в десятичную дробь, но я так вижу.
    public  bool Equals(RatNum r1)
    {
        if (r1.D == D)
            return (r1.N == N);
        return (r1.N * D == N * r1.D); ;
    }

    public override int GetHashCode()
    {
        return N.GetHashCode() * D.GetHashCode();
    }


    public static bool operator == (RatNum r1, RatNum r2)
    {
        return r1.Equals(r2);
    }

    public static bool operator !=(RatNum r1, RatNum r2)
    {
        return ! r1.Equals(r2);
    }

    public static bool operator > (RatNum r1, RatNum r2)
    {
        if (r1.D == r2.D)
            return(r1.N > r2.N);
        return (r1.N * r2.D > r2.N*r1.D); //сравнение через приведение к общему знаменателю
    }
    public static bool operator <(RatNum r1, RatNum r2)
    {
        if (r1.D == r2.D)
            return (r1.N < r2.N);
        return (r1.N * r2.D < r2.N * r1.D); //сравнение через приведение к общему знаменателю
    }
    public static bool operator <= (RatNum r1, RatNum r2)
    {
        if (r1.D == r2.D)
            return (r1.N <= r2.N);
        return (r1.N * r2.D <= r2.N * r1.D); //сравнение через приведение к общему знаменателю
    }
    public static bool operator >=(RatNum r1, RatNum r2)
    {
        if (r1.D == r2.D)
            return (r1.N >= r2.N);
        return (r1.N * r2.D >= r2.N * r1.D); //сравнение через приведение к общему знаменателю
    }


    //Арифметика
    public static RatNum operator + (RatNum r1 , RatNum r2)
    {
        if (r1 == 0) { return r2; }
        if (r2 == 0) { return r1; }
        if (r1.D == r2.D)
        {
            return new RatNum(r1.N + r2.N, r1.D);
        }
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

    public static RatNum operator ++ (RatNum r)
    {
        r.D++;
        r.N++;
        return r;
    }
    public static RatNum operator --(RatNum r)
    {
        r.D--;
        r.N--;
        return r;
    }

    public static explicit operator float(RatNum n)
    {
        return (float) n.N / n.D;
    }

    public static implicit operator int(RatNum n)
    {
        return n.N / n.D;
    }


    //не до конца понял, для чего нужно переоределять этот оператор, если деление дробей - это, по сути, их умножение с переворотом дроби после "/",  где в этом случае искать остаток?
    //или я чего-то не понял
    //public static ratnum operator %(ratnum r)
    //{
    //   return ;
    //}




    public override string ToString()
    {
        return N + "/" + D ;
    }





}
