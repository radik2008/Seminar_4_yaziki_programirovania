﻿using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int a3 = 0;
if (a < 0) a *= -1;   //игнорируем '-' если число отрицательное

if (a >= 100)
{
    while (a > 100)      
    {
        a3 = a%10;              // фиксируем последнюю цифру числа (которое, пока, имеет не меньше 3 цифр)
        a = (a-a%10)/10;       // отрезаем 'хвост состоящий из одной цифры' пока число не станет двузначным
    }
    WriteLine(a3);
}
else WriteLine("Третьей цифры нет");