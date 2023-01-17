// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Write("Введите крайний верхний диапозон значения массива:");
int a = int.Parse(Console.ReadLine());
Write("Введите крайний нижний диапозон значения массива:");
int b = int.Parse(Console.ReadLine());
Write("Введите длинну массивва:");
int с = int.Parse(Console.ReadLine());

int[] array = new int[с];
FillArray(array);
PrintArray(array);

WriteLine();
WriteLine($"сумма элементов, стоящих на нечётных позициях {sumAr(array)} ");


// int f = 1%2;   остаток от деления 1на 2 =1
// WriteLine(f);

int sumAr(int[]ar)
{
    int res = 0;

    for (int i = 1; i < ar.Length; i++)
    {
        if(i%2==1)res=res+ar[i];
    }
    return res;
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