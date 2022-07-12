
namespace Bank;

public enum TypeEnum
{
    VIP = 1, //особые условие
    Normal = 2, //обычные условия
    Corp = 3, //корпоративные условия(зарплатная карта)
    Comp = 4, //счет компании
}

public class Account
 {
    static int Counter = 0; //переменная для генератора ID

    private int _Id; 
    private decimal _Cash;
    private TypeEnum _Type;
     
    public int ID
    {
        get => _Id;
    }
        
    public decimal Cash
    {
        get => _Cash;
        set => _Cash = value;
    }

    public TypeEnum Type
    {
        get => _Type;
        set => _Type = value;
    }

    /// <summary>
    /// перевод средств
    /// </summary>
    /// <param name="source">источник средств</param>
    /// <param name="amount">количество средств</param>
    public void Transfer(Account source, decimal amount)
    {
        decimal lessZeroCheck = Cash - amount;

        if (lessZeroCheck < 0)
        {
            throw new ArgumentException("Недостаточно средств.");
        }

        source.Cash = source.Cash - amount;
        Cash += amount;
    }

    /// <summary>
    /// Генератор ID
    /// </summary>
    private static int IdGen()
    {
       return Counter++;        
    }

    /// <summary>
    /// конструктор
    /// </summary>
    public Account(decimal cash, TypeEnum type)
    {
        _Type = type;
        _Cash = cash;
        _Id = IdGen();
    }

    /// <summary>
    /// Снять стредства
    /// </summary>
    /// <param name="money">сумма</param>
    public void CashOut (decimal money)
    {
        decimal lessZeroCheck = Cash - money;
        if (lessZeroCheck < 0)
        {
            throw new ArgumentException("Недостаточно средств.");
        }
            
        
        Cash -= money;

    }

    /// <summary>
    /// Зачислить средства
    /// </summary>
    /// <param name="money">сумма</param>
    public void CashIn(decimal money)
    {
        Cash += money;       
    }

    /// <summary>
    /// Сравнение только типов, ибо идентификатор у счетов не может быть одинаков, а сравнивать кол-во средств не вижу смысла
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public bool Equals (Account obj)
    {
        return (obj.Type == this.Type);             
    }

    public static bool operator ==(Account a, Account b)
    {
        return a.Equals(b);
    }

    public static bool operator !=(Account a, Account b)
    {
        return ! a.Equals(b);
    }


    //todo
    public override string ToString()
    {
        return base.ToString();
    }
    
}

