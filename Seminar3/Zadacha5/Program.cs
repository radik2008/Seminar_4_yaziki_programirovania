//Вывести квадратиы чисел от 1 до N
using static System.Console;
Clear();
Write("ВВедите число :");
int n = int.Parse(ReadLine());

while(n>0)     //такая запись избавляет от доп переменной
{
    WriteLine($"число {n} в квадрате будет {Math.Pow(n,2)}");
    n--;        //такая запись избавляет от доп переменной
}