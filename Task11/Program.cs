using static System.Console;
Clear();
WriteLine("Введите  число:");
int a = int.Parse(Console.ReadLine());
int count = 2;
while(count <= a)
{
    WriteLine(count);
    count+=2;
}