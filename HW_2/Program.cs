using HW_2.Account;

Account Acc1 = new();

Acc1.Cash = 5000000000000M;
Acc1.Type = TypeEnum.VIP;
Acc1.Writeinfo(Account.Id, Acc1.Cash, Acc1.Type);

Account Acc2 = new();
Acc2.Cash = 4521547.22M;
Acc2.Type = TypeEnum.Normal;
Acc2.Writeinfo(Account.Id, Acc2.Cash, Acc2.Type);

Account Acc3 = new();
Acc3.Cash = 123.01M;
Acc3.Type = TypeEnum.Corp;
Acc3.Writeinfo(Account.Id, Acc3.Cash, Acc3.Type);

Account Acc4 = new();
Acc4.Cash = 800265324;
Acc4.Type = TypeEnum.Comp;
Acc4.Writeinfo(Account.Id, Acc4.Cash, Acc4.Type);






