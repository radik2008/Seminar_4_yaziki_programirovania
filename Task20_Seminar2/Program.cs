﻿// введите 2 числа, и проверьте является ли одно двадратом дркгого и наоборот
using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine());
if (a == b * b)
{
    WriteLine($"{a} является квалратом числом числа {b} ");

}
else
{
    WriteLine($"{a} не является квалратом числом числа {b} ");

}
WriteLine (b == a * a? $"{b} является кватратом {a}":$"{b} не является кватратом {a}");
WriteLine (b == a * a || a == b*b? $" является кватратом ":$"не является кватратом");
