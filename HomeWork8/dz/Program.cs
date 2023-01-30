// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//  Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //


PrintMatrixArray(array);
WriteLine();


WriteLine($"строка с наименьшей суммой элементов :{SearchMinString(array)+1}");
WriteLine();

int SearchMinString(int[,] arr)
{
    int resMinSum = 0;
    int resMinNomberString = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < 1)
            {
                sum += arr[i, j];
                resMinSum += arr[i, j];
            }
            else
            {
                sum += arr[i, j];
            }
        }
        if (sum < resMinSum) 
        {
            resMinSum = sum;
            resMinNomberString=i;
        }
    }
    return resMinNomberString;
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
