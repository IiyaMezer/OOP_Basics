using HW_2.Account;

Account Acc1 = new();
Acc1.Id = 111;
Acc1.Cash = 5000000000000M;

Account Acc2 = new();
Acc2.Id = 222;
Acc2.Cash = 4521547.22M ;

Account Acc3 = new();
Acc3.Id = 333;
Acc3.Cash = 123.01M;

Account Acc4 = new();
Acc4.Id = 444;
Acc4.Cash = 800265324;

Acc1.Writeinfo(Acc1.Id, Acc1.Cash);
Acc2.Writeinfo(Acc2.Id, Acc2.Cash);
Acc3.Writeinfo(Acc3.Id, Acc3.Cash);
Acc4.Writeinfo(Acc4.Id, Acc4.Cash);




