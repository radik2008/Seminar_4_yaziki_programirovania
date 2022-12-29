//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
using static System.Console;
Clear();
WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(ReadLine());
WriteLine(number > 99 && number < 1000 ? (number/10)%10: "смотри че пишешь");
