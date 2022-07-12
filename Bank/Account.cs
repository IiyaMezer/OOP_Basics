
namespace Bank;
 internal class Account
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
        this._Type = type;
        this._Cash = cash;
        this._Id = IdGen();
    }

    /// <summary>
    /// Снять стредства
    /// </summary>
    /// <param name="money">сумма</param>
    public void CashOut (decimal money)
    {
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
 
 }

