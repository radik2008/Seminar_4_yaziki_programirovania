Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
    Console.WriteLine($"{a} больше {b}");
}
if(a < b)
{
    Console.WriteLine($"{a} меньше {b}");
}
if(a == b)
{
    Console.WriteLine($"{a} равно {b}");
}