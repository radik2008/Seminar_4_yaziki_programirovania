using static System.Console;
Clear();
WriteLine("Введите первое число");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число");
int b = int.Parse(ReadLine());
WriteLine(a % b == 0 ? "b кратно a" :$"{a%b} остаток от деления");
