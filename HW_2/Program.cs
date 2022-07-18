using Bank;


Account Acc1 = new(10600000M, TypeEnum.VIP);
Account Acc2 = new(5000000M, TypeEnum.Normal);
Account Acc3 = new(10M, TypeEnum.Comp);
Account Acc4 = new(10M, TypeEnum.Comp);
Console.WriteLine(Acc1);
Console.WriteLine();
Console.WriteLine(Acc2);

Console.WriteLine(Acc4 == Acc3);





Console.ReadLine();




