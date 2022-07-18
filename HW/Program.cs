using Math;

Fractions n1 = new(2, 8);
Fractions n2 = new(3, 8);
Fractions n3 = new(2, 8);
Fractions n4 = new(2, 7);

Console.WriteLine();

Console.WriteLine("n1 == n2 = {0} ", n1 == n2); //F
Console.WriteLine();
Console.WriteLine("n1 == n3 = {0}", n1 == n3); //T
Console.WriteLine();
Console.WriteLine("n3.Equals(n2) = {0}", n3.Equals(n2));//F
Console.WriteLine();
Console.WriteLine("n1 != n2 = {0}", n1 != n2);//T
Console.WriteLine();
Console.WriteLine("n3 != n1 = {0}", n3 != n1);//F
Console.WriteLine();
Console.WriteLine("n3 > n1 = {0}", n3 > n1);//F
Console.WriteLine();
Console.WriteLine("n2 > n1 = {0}", n2 > n1);//T      
Console.WriteLine();
Console.WriteLine("n1 > n4 = {0}", n1 > n4);//F
Console.WriteLine();
Console.WriteLine("n1 >= n3 = {0}", n1 >= n3);//T
Console.WriteLine();
Console.WriteLine($"{n3} * {n1}= {n3 * n1}");
Console.WriteLine();
Console.WriteLine($"{n1} * {n4}= {n1 * n4}");
Console.WriteLine();
Console.WriteLine($"{n1} + {n2}= {n1 + n2}");
Console.WriteLine();
Console.WriteLine($"{n1} + {n4}= {n1 * n4}");
Console.WriteLine();
Console.WriteLine($"{n2} - {n1}= {n2 - n1}");
Console.WriteLine();
Console.WriteLine($"{n4} - {n1}= {n4 - n1}");
Console.WriteLine();
Console.WriteLine($"{n1} div {n4}= {n1 / n4}"); //деление, div чтобы избежать вида многоэтажной дроби 1/2/3/5
Console.WriteLine();
Console.WriteLine($"{n1} div {n4}= {n1 / n4}"); 
Console.WriteLine();
Console.WriteLine($"{n1}");
Console.WriteLine("++");
Console.WriteLine($"{n1++}");
Console.WriteLine("--");
Console.WriteLine($"{n1--}");

Complex c1 = new(2, -3);
Complex c2 = new(3, 4);
Complex c3 = new(3, 4);
Console.WriteLine($"{c1} * {c2} = {c1 * c2}");
Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

Console.WriteLine(c3 == c2);//t
Console.WriteLine(c1 == c3);//f


Console.ReadLine();   