// написатьт программу которая выдает количество чисел в числе, использовать методы

using static System.Console;
Clear();

int CountNumbers(int A)
{
    int result = 0;
    while (A > 0)
    {
        result = result + 1;
        A /= 10;     //   A=A/10
    }

    return result;
}
WriteLine("Input number:");
int.TryParse(ReadLine(), out int num);
int count = CountNumbers(num);
WriteLine($"Count numbers = {count}");