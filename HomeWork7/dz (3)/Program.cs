// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9




using static System.Console;

Clear();
Write("Введите размер матрицы и позиции элемента через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]));    //



PrintMatrixArray(array);
WriteLine();
SearchPosition(array, intParams[2], intParams[3]);



void SearchPosition(int[,] arr, int x, int y)
{
    // (x <= arr.GetLength(0) && y <= arr.GetLength(1)) ? WriteLine($"на даной позиции элемент - {arr[x, y]}") : WriteLine($"Такого элемента нет!!!");
    WriteLine((x <= arr.GetLength(0) && y <= arr.GetLength(1)) ?($"на даной позиции элемент: {arr[x, y]}") :($"Такого элемента нет!!!"));
}

int[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
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
