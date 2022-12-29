// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//23432 -> да

using static System.Console;
Clear();
Write("ВВедите ПЯТИЗНАЧНОЕ ЧИСЛО :");
int num = int.Parse(ReadLine());
WriteLine(num > 9999 && num < 100000 ? num % 10 == (num / 10000) && (num / 10) % 10 == (num / 1000) % 10 ? $"{num} - число зеркальное" : $"{num} не зеркальное" : "Erorr");
WriteLine(num % 10);
WriteLine(num / 10000);
WriteLine((num / 10) % 10);
WriteLine((num / 1000) % 10);