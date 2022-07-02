
namespace HW_2.Account;
 internal class Account
 {
    static int id = 0; //переменная для генератора ID
    private decimal _Cash;
    private TypeEnum _Type;

    public static int Id => id;
    
    /// <summary>
    /// Счетчик + конструктор
    /// </summary>
    public Account(decimal cash, TypeEnum type)
    {
        this._Type = type;
        this._Cash = cash;
        id++;

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

   
    public void Writeinfo()
    {
        Console.WriteLine($"Номер счета: {id:d8};");
        Console.WriteLine($"Баланс {Cash} руб. ;");
        Console.WriteLine($"Тип {Type};");
        Console.WriteLine("");
    }
 }

