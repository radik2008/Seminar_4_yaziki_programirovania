// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;
Clear();

int Sqvard(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
        {
            result=result*A;
        } 
    return result;
}


Write("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

WriteLine($"{a} в степени {b} равно {Sqvard(a,b)}");
