
namespace OOP_Basics.Account;
 internal class Account
 {
    static int id = 0; //переменная для генератора ID

    private int _Id; 
    private decimal _Cash;
    private TypeEnum _Type;

    public static int Id => id;

    void IdGen()
    {
        id++;
        _Id = id;
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

    public void CashOut (decimal money)
    {
        if (Cash < money)
        {
            Console.WriteLine("Not enough money");
        }
        else
        {
          Cash -= money;
        }
            
    }
    public void CashIn(decimal money)
    {
        Cash += money;       
    }

   
    public void Writeinfo()
    {
        Console.WriteLine($"Номер счета: {ID:d8};");
        Console.WriteLine($"Баланс {Cash} руб. ;");
        Console.WriteLine($"Тип {Type};");
        Console.WriteLine("");
    }
 }

