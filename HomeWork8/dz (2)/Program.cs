// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //


PrintMatrixArray(array);
WriteLine();
CheangeMatrixArray(array);
WriteLine();
PrintMatrixArray(array);
WriteLine();

void CheangeMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            int minPoz = j;
            for (int y = j + 1; y < arr.GetLength(1); y++)   //// находим минимум в строке
            {

                if (arr[i, y] < arr[i,minPoz])                //// находим минимум в строке
                {
                    minPoz = y;
                }
            }
            int temporary = arr[i, j];
            arr[i, j] = arr[i,minPoz];
            arr[i, minPoz] = temporary;

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
