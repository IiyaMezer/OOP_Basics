using HW_5.Class;

RatNum n1 = new(2, 5);
RatNum n2 = new(2, 6);
RatNum n3 = new(2, 5);

Console.WriteLine(n1 == n2); //false
Console.WriteLine(n1 == n3); //true
Console.WriteLine();
Console.WriteLine(n1 != n2);//true
Console.WriteLine(n3 != n1);//false

Console.ReadLine();   