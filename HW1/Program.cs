using HW_5.Class;

RatNum n1 = new(2, 8);
RatNum n2 = new(2, 6);
RatNum n3 = new(3, 8);

Console.WriteLine(n1 == n2); //false
Console.WriteLine(n1 == n3); //true

Console.WriteLine(Equals(n3,n2));//false

Console.WriteLine(n1 != n2);//true
Console.WriteLine(n3 != n1);//false

Console.WriteLine(n3 > n1);

Console.WriteLine(n3 * n1);

Console.WriteLine(n1 + n2);


Console.WriteLine(n1);
Console.ReadLine();   