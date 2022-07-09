using HW_5.Class;

RatNum n1 = new(2, 5);
RatNum n2 = new(2, 6);
RatNum n3 = new(2, 5);

bool a = n1 == n2; //false
bool a = n1 == n3; //true

bool a = n1 != n2;//true
bool a =  n3 != n1;//false
Console.ReadLine();   