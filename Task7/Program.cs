using static System.Console;

WriteLine("Введите  число трехзначное: ");
int n = int.Parse(Console.ReadLine());
if(n > 99 && n < 1000)
{
    WriteLine(n%10);
}
else
{
    WriteLine("Ввели неверное число");
}