// Задача 34: Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();

WriteLine("Введите длинну массивва:");
int с = int.Parse(Console.ReadLine());

int[] array = new int[с];
FillArray(array);
PrintArray(array);

WriteLine();
Write($"количество четных чисел равно {count(array)} ");

int count(int[]ar)
{
    int res = 0;
    foreach (int item in ar)
    {
        if (item%2==0) res++;
    }
    return res;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] Ar)
{
    for (int i = 0; i < Ar.Length; i++)
    {
        Write($"{Ar[i]} ");
    }
}