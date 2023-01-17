// написать программу которая принимает значения для постороениея массива

using static System.Console;
Clear();

Write("Введите размер массива, мин и макс значение через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArr(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);

WriteLine();
int negativeSum = 0;
int positiveSum = 0;
foreach (int a in array)
{
    negativeSum = negativeSum + a < 0 ? a : 0;
    positiveSum = positiveSum + a > 0 ? a : 0;
}
WriteLine($"{negativeSum}       {positiveSum}");

int[] GetArr(int size, int min, int max)
{
    int[] Result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        Result[i] = rnd.Next(min, max + 1);
    }
    return Result;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length-1]}]");
}

