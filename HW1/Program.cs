﻿using HW_5.Class;

RatNum n1 = new(2, 8);
RatNum n2 = new(3, 8);
RatNum n3 = new(2, 8);
RatNum n4 = new(2, 7);

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine();

Console.WriteLine("n1 == n2 = " , n1 == n2); //F
Console.WriteLine();
Console.WriteLine("n1 == n3=", n1 == n3); //T
Console.WriteLine();
Console.WriteLine("n3.Equals(n2)=", n3.Equals(n2));//F
Console.WriteLine();
Console.WriteLine("n1 != n2=", n1 != n2);//T
Console.WriteLine();
Console.WriteLine("n3 != n1=", n3 != n1);//F
Console.WriteLine();
Console.WriteLine("n3 > n1=", n3 > n1);//F
Console.WriteLine();
Console.WriteLine("n2 > n1=", n2 > n1);//T      
Console.WriteLine();
Console.WriteLine("n1 > n4=", n1 > n4);//F
Console.WriteLine();
Console.WriteLine("n1 >= n3=", n1 >= n3);//T
Console.WriteLine();
Console.WriteLine($"{n3} * {n1}= {n3 * n1}"); 
Console.WriteLine();
Console.WriteLine($"{n1} + {n2}= {n1 * n2}"); 
Console.WriteLine();
Console.WriteLine($"{n1} + {n2}= {n1 * n2}");
Console.WriteLine();
Console.WriteLine($"{n1} + {n2}= {n1 * n2}");
Console.WriteLine();

Console.WriteLine("n2 - n1=", n2 - n1);
Console.WriteLine();


Console.ReadLine();   