﻿

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
    public static bool Equals(RatNum r1, RatNum r2)
    {
        return ((float)r1.N / r1.D == (float)r2.N / r2.D);
    }
    public bool Equals(RatNum r)
    {
        return ((float)N / D == (float)r.N / r.D);
    }


    public static bool operator == (RatNum r1, RatNum r2)
    {
        return  ((float)r1.N/r1.D == (float)r2.N / r2.D);
    }

    public static bool operator !=(RatNum r1, RatNum r2)
    {
        return (r1.N / r1.D != r2.N / r2.D);
    }

    public static bool operator > (RatNum r1, RatNum r2)
    {
        return ((float)(r1.N / r1.D) > (float)(r2.N / r2.D));
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




    public override string ToString()
    {
        return N + "/" + D ;
    }





}