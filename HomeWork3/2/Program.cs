// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();
Write("ВВедите  ЧИСЛО :");
if (!int.TryParse(ReadLine(), out int n))
{
    Write("Введено не число :");
}
int count = 1;

while (count <= n)
{
    Write($"число {count} в кубе будет {Math.Pow(count, 3)}");
    if (n != count) WriteLine(", ");   //делаем красоту со знаками между числами и в конце ряда
    else Write(".");
    count += 1;
}