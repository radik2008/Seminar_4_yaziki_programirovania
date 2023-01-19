// Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();

WriteLine("Введите длинну массивва:");
int с = int.Parse(Console.ReadLine());

double[] array = new double[с];
FillArray(array);
PrintArray(array);

WriteLine();
Write($"разницы между максимальным и минимальным элементов массива {Result(array):f2}");


double Result(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    foreach (var it in arr)
    {
        if (it > max) max = it;
        if (it < min) min = it;
    }
    WriteLine(max);
    WriteLine(min);
    double res = max - min;
    return res;
}

void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToDouble(new Random().Next(10000) / 100.0);
        //index = index + 1;
        index++;
    }
}

void PrintArray(double[] Ar)
{
    Write("[");
    for (int i = 0; i < Ar.Length - 1; i++)
    {
        Write($"{Ar[i]}  ");
    }
    Write($"{Ar[Ar.Length - 1]}]");
}
