using HW_5.Class;

RatNum n1 = new(2, 8);
RatNum n2 = new(2, 6);
RatNum n3 = new(2, 5);

bool a = n1 == n2; //false
bool b = n1 == n3; //true

bool c = n1 != n2;//true
bool d =  n3 != n1;//false

Console.WriteLine(n1);
Console.ReadLine();   