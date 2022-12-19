using static System.Console;
Clear();
WriteLine("Введите  число :");
int a = int.Parse(Console.ReadLine());
if(a%2 == 0) WriteLine($"{a} четное число!");
else WriteLine($"{a} нечетное число!");
