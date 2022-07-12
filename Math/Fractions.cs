namespace Math;

public class Fractions
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

    public Fractions (int n, int d)
    {
        if (d == 0)
            throw new ArgumentException("Знаменатель не должен быть равен 0."); // мы же пока в высшую математику не лезем.

        this._N = n;
        this._D = d;
    }

    //Булевы
    //Скорее всего это варварские методы, это я про промежуточный перевод в десятичную дробь, но я так вижу.
    public bool Equals(Fractions r1)
    {
        if (r1.D == D)
            return (r1.N == N);
        return (r1.N * D == N * r1.D); ;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(N, D);
    }


    public static bool operator == (Fractions r1, Fractions r2)
    {
        return Equals(r1, r2);
    }

    public static bool operator !=(Fractions r1, Fractions r2)
    {
        return !(r1 ==r2);
    }

    public static bool operator > (Fractions r1, Fractions r2)
    {
        if (r1.D == r2.D)
            return(r1.N > r2.N);
        return (r1.N * r2.D > r2.N*r1.D); //сравнение через приведение к общему знаменателю
    }
    public static bool operator <(Fractions r1, Fractions r2)
    {
        if (r1.D == r2.D)
            return (r1.N < r2.N);
        return (r1.N * r2.D < r2.N * r1.D); //сравнение через приведение к общему знаменателю
    }
    public static bool operator <= (Fractions r1, Fractions r2)
    {
        if (r1.D == r2.D)
            return (r1.N <= r2.N);
        return (r1.N * r2.D <= r2.N * r1.D); //сравнение через приведение к общему знаменателю
    }
    public static bool operator >=(Fractions r1, Fractions r2)
    {
        if (r1.D == r2.D)
            return (r1.N >= r2.N);
        return (r1.N * r2.D >= r2.N * r1.D); //сравнение через приведение к общему знаменателю
    }


    //Арифметика
    public static Fractions operator + (Fractions r1 , Fractions r2)
    {
        
        if (r1.D == r2.D)
        {
            return new Fractions(r1.N + r2.N, r1.D);
        }
       return new Fractions((r1.N * r2.D)+ (r2.N * r1.D), r1.D * r2.D);
    }
    public static Fractions operator - (Fractions r1, Fractions r2)
    {
        if (r1.D == r2.D)
        {
            return new Fractions(r1.N - r2.N, r1.D);
        }
        return new Fractions((r1.N * r2.D) - (r2.N * r1.D), r1.D * r2.D);
    }
    public static Fractions operator * (Fractions r1, Fractions r2)
    {
        if (r1.D == r2.D)
            return new Fractions(r1.N * r2.N, r1.D);
        return new Fractions(r1.N * r2.N, r1.D * r2.D);
    }
    public static Fractions operator / (Fractions r1, Fractions r2)
    {
        return new Fractions(r1.N * r2.D, r1.D * r2.N);
    }

    public static Fractions operator ++ (Fractions r)
    {
        r.N += r.D;
        return r;
    }
    public static Fractions operator --(Fractions r)
    {
        r.N -= r.D;
        return r;
    }

    public static explicit operator float(Fractions n)
    {
        return (float) n.N / n.D;
    }

    public static implicit operator int(Fractions n)
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
