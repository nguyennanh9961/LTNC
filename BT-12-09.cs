using System;
using System.Collections.Generic;

Console.WriteLine("Hello World!");
int a;
int b;
int c;
Console.WriteLine("Nhap a:");
a = Convert.ToInt32(Console.ReadLine());
while (true)
{
    Console.WriteLine("Nhap b: ");
    try
    {
        b = Convert.ToInt32(Console.ReadLine());
        break;

    }
    catch (Exception)
    {
        Console.WriteLine("Nhap sai, vui long nhap lai");
    }
}
while (true)
{
    Console.WriteLine("Nhap c: ");
    bool k = int.TryParse(Console.ReadLine(), out c);
    if (k)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nhap sai, vui long nhap lai");
    }
}

Console.WriteLine($"a + b + c = {a + b + c}");
