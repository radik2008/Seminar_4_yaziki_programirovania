// Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.


using static System.Console;
Clear();

Write("Введите крайний верхний диапозон значения массива:");
int a = int.Parse(Console.ReadLine());
Write("Введите крайний нижний диапозон значения массива:");
int b = int.Parse(Console.ReadLine());
Write("Введите длинну массивва:");
int с = int.Parse(Console.ReadLine());

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
         collection[i] = new Random().Next(b,a);
    }
        
}

void PrintArray(int[] Ar)
{
    for (int i = 0; i < Ar.Length; i++)
    {
        Write($"{Ar[i]} ");
    }
}

int [] array = new int[с];
FillArray(array);
PrintArray(array);