// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //

PrintMatrixArray(array);
WriteLine();
WriteLine($"Сумма элементов по диагонали равно {SumDiagonal(array)}");


int SumDiagonal(int[,] arra)
{
    int res = 0;
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            if (i == j)
            {
                res += arra[i, j];
            }
        }
    }
    return res;
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