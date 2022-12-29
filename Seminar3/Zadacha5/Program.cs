//Вывести квадратиы чисел от 1 до N
using static System.Console;
Clear();
Write("ВВедите число :");
int n = int.Parse(ReadLine());
int count= 0;
while(count<=n)
{
    WriteLine(count*count);
    count+=1;
}