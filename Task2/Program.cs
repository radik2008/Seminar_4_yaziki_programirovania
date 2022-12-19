Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if(a*a == b)
{
   Console.WriteLine($"{b} квадрат числа {a}");
}
else
{
    Console.WriteLine($"{b} не является квадратом числа {a}");
}
