//задача дан масиив и диапозон, посчитать сколько чисел попадает в диапозон
using static System.Console;
Clear();

Write("Введите крайний верхний диапозон значения массива:");
int a = int.Parse(Console.ReadLine());
Write("Введите крайний нижний диапозон значения массива:");
int b = int.Parse(Console.ReadLine());
Write("Введите длинну массивва:");
int с = int.Parse(Console.ReadLine());

int[] array = new int[с];

Write("Введите диапозон чисел  через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);  // вместо " " можно написать new char[]{' ', ':', '#'  } и перечислить все разделители


FillArray(array);
PrintArray(array);
WriteLine();

SearshDiapozone(array, int.Parse(parameters[0]), int.Parse(parameters[1]));
WriteLine();

WriteLine(Sears2(array, int.Parse(parameters[0]), int.Parse(parameters[1])));


void SearshDiapozone(int[] arr, int min, int max)          ///первый вариан решения он сразу считает и выводит
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item>=min && item<=max) count = count + 1;
    }
    Write($"В этом диапозоне {count} чисел");
}

int Sears2(int[] arr, int min, int max)                   //второй вариант решения просто считатет
{
    int Result=0;
    foreach (var item in arr)
    {
        if (item>=min && item<=max) Result++;
    }
    return Result;
}


void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(b, a);
    }

}



void PrintArray(int[] Ar)
{
     Write("[");
    for (int i = 0; i < Ar.Length - 1; i++)
    {
        Write($"{Ar[i]}, ");
    }
    Write($"{Ar[Ar.Length - 1]}]");

}