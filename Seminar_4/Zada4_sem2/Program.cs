// написатьт программу которая выдает сумму чисел в числе, использовать методы

using static System.Console;
Clear();

int CountSum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result = result + A % 10;
        A = A / 10;
    }

    return result;
}
WriteLine("Input number:");
int num = int.Parse(ReadLine());
int sum = CountSum(num);
WriteLine($"Sum numbers = {sum}");