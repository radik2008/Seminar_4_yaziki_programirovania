// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
using static System.Console;
Clear();
Write("ВВедите  ЧИСЛО :");
int n = int.Parse(ReadLine());
int count = 1;

while (count <= n)
{
    WriteLine($"число {count} в кубе будет {Math.Pow(count, 3)}");
    count += 1;
}