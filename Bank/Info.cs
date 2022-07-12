namespace Bank;

public class Info
{
    public static void Writeinfo(Account acc)
    {
        Console.WriteLine($"Номер счета: {acc.ID:d8};");
        Console.WriteLine($"Баланс {acc.Cash} руб. ;");
        Console.WriteLine($"Тип {acc.Type};");
        Console.WriteLine("");
    }
}
