
namespace HW_2.Account;
 internal class Account
 {
    static int id = 0; //переменная для генератора ID
    private decimal _Cash;
    private TypeEnum _Type;

    public static int Id => id;
    
    /// <summary>
    /// Счетчик
    /// </summary>
    public Account()
    {
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

   
    public void Writeinfo(int id, decimal cash, TypeEnum type)
    {
        Console.WriteLine($"Номер счета: {id:d8};");
        Console.WriteLine($"Баланс {cash} руб. ;");
        Console.WriteLine($"Тип {type};");
        Console.WriteLine("");
    }
 }

