// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");



int[] intParams=Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries),int.Parse); // сразу перевели строчку в масив из чисел

double[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //

PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] resultArray = new double[rows, columns];

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] =  Convert.ToDouble(new Random().Next(minValue*100, maxValue*100+1)/100.0);;
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],10} ");
        }
        WriteLine();
    }
}