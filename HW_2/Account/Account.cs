
namespace OOP_Basics.Account;
 internal class Account
 {
    static int id = 0; //переменная для генератора ID

    private int _Id; 
    private decimal _Cash;
    private TypeEnum _Type;

    public static int Id => id;
    
    int ID
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
        return id++;
    }

    /// <summary>
    /// конструктор
    /// </summary>
    public Account(decimal cash, TypeEnum type)
    {
        this._Type = type;
        this._Cash = cash;
        IdGen();
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

   /// <summary>
   /// Вывод информации о счете
   /// </summary>
    public void Writeinfo()
    {
        Console.WriteLine($"Номер счета: {ID:d8};");
        Console.WriteLine($"Баланс {Cash} руб. ;");
        Console.WriteLine($"Тип {Type};");
        Console.WriteLine("");
    }
 }

