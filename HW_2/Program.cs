using OOP_Basics.Account;

 Account Acc1 = new(10M, TypeEnum.VIP);
 Account Acc2 = new(10M, TypeEnum.Normal);
 Account Acc3 = new(10M, TypeEnum.Corp);
 Account Acc4 = new(10M, TypeEnum.Comp);


Console.WriteLine("========================");
Acc1.CashIn(50M);//добавляем денег
Console.WriteLine(Acc1.Cash);//проверка баланса

Acc1.CashOut(70M);//пытаемся снять больше положенного
Console.WriteLine(Acc1.Cash);//проверка баланса

Acc1.CashOut(60M);//пытаемся снять в ноль
Console.WriteLine(Acc1.Cash);//проверка баланса

Acc1.CashIn(60M);//добавляем денег
Console.WriteLine(Acc1.Cash);//проверка баланса

Acc1.CashOut(30M);//пытаемся снять в пределах допустимого
Console.WriteLine(Acc1.Cash);//проверка баланса
Console.WriteLine("========================");
Acc4.Transfer(Acc1, 1M);
Console.WriteLine(Acc4.Cash);//проверка баланса
Console.WriteLine(Acc1.Cash);//проверка баланса

Console.WriteLine("========================");

Acc1.Writeinfo();
Acc2.Writeinfo();
Acc3.Writeinfo();
Acc4.Writeinfo();





