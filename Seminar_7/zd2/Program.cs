using System.ComponentModel;
using System;
// Тимур: **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4

// Создание двухмерного масива, и вывод на экран
using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
PrintMatrixArray(array);
WriteLine();

int[,] array2 = CheangeArray(array);
PrintMatrixArray(array2);
WriteLine();

int[,] array3 = CheangeArray2(array);
PrintMatrixArray(array3);
WriteLine();

CheangeArray3(array);
PrintMatrixArray(array);
WriteLine();

int[,] CheangeArray(int[,] arr)              // через новый масив, так же можно через изменение имеюшегося тогда будет метод воид
{
    int[,] resultArray = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                resultArray[i, j] = arr[i, j] * arr[i, j];
            }
            else
            {
                resultArray[i, j] = arr[i, j];
            }
        }
    }
    return resultArray;

}

int[,] CheangeArray2(int[,] arra)              // через новый масив, методом клонирования
{
    int[,] resultArray = arra.Clone() as int[,];
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                resultArray[i, j] = arra[i, j] * arra[i, j];
            }
        }
    }
    return resultArray;
}

void CheangeArray3(int[,] arr)              // через void замена имеющегося
{
    for (int i = 2; i < arr.GetLength(0); i+=2)
    {
        for (int j = 2; j < arr.GetLength(1); j+=2)
        {
            if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                arr[i, j] *= arr[i, j];
            }
        }
    }
}

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}

