﻿//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
using static System.Console;
Clear();
WriteLine("Введите число от 1 до 7");
int den = Convert.ToInt32(ReadLine());
WriteLine( den >= 1 && den < 8 ? den == 6 || den == 7 ? "ВЫХОДНОЙ ДЕНЬ" : "РАБОЧИЙ ДЕНЬ" : "ВВЕЛИ НЕ ТО ЧИСЛО");

