// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



using static System.Console;
Clear();

Write("Введите размер матрицы 1 и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array1 = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //

Write("Введите размер матрицы 2 и диапазон значений через пробел: ");

int[] intParams2 = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array2 = GetMatrixArray((intParams2[0]), (intParams2[1]), (intParams2[2]), (intParams2[3]));    //





PrintMatrixArray(array1);
WriteLine();
PrintMatrixArray(array2);
int[,] array3=ProizMatrix(array1,array2);
WriteLine();
PrintMatrixArray(array3);


int[,] ProizMatrix(int[,] ar1, int[,] ar2)
{
    int[,] resAr = new int[ar1.GetLength(0), ar2.GetLength(1)];
    if (ar1.GetLength(1) == ar2.GetLength(0))
    {
        for (int i = 0; i < ar1.GetLength(0); i++)
        {
            for (int j = 0; j < ar2.GetLength(1); j++)
            {
                for (int k = 0; k < ar1.GetLength(1); k++)
                    {
                        resAr[i,j] += ar1[i,k] * ar2[k,j];
                    }
               
            }

        }

    }
    else WriteLine("Операция невозможна!");
    return  resAr;
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
