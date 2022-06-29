
namespace HW_2.Account;
 internal class AccountTask1
 {
    private int _Id;
    private decimal _Cash;
    private TypeEnum _Type;

    public int Id
    {
        get => _Id;
        set => _Id = value;
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
        Console.WriteLine($"Номер счета: {id};");
        Console.WriteLine($"Баланс {cash} руб. ;");
        Console.WriteLine($"Тип {type};");
        Console.WriteLine("");
    }
 }

