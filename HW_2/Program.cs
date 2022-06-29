using HW_2.Account;

AccountTask1 Acc1 = new();
Acc1.Id = 111;
Acc1.Cash = 5000000000000M;
Acc1.Type = TypeEnum.VIP;


AccountTask1 Acc2 = new();
Acc2.Id = 222;
Acc2.Cash = 4521547.22M;
Acc2.Type = TypeEnum.Normal;

AccountTask1 Acc3 = new();
Acc3.Id = 333;
Acc3.Cash = 123.01M;
Acc3.Type = TypeEnum.Corp;

AccountTask1 Acc4 = new();
Acc4.Id = 444;
Acc4.Cash = 800265324;
Acc4.Type = TypeEnum.Comp;

Acc1.Writeinfo(Acc1.Id, Acc1.Cash, Acc1.Type);
Acc2.Writeinfo(Acc2.Id, Acc2.Cash, Acc2.Type);
Acc3.Writeinfo(Acc3.Id, Acc3.Cash, Acc3.Type);
Acc4.Writeinfo(Acc4.Id, Acc4.Cash, Acc4.Type);




