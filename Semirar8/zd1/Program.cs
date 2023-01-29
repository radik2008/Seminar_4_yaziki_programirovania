// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;
using MyLib;
Clear();


int[,] ar = MyMetods.GetMatrixArray(3, 4, 10, 99);
MyMetods.PrintMatrixArray(ar);

WriteLine();

int[,] ar2 = CheangeArray(ar);
MyMetods.PrintMatrixArray(ar2);



int[,] CheangeArray(int[,] arr)
{
    int[,] arr2 = arr.Clone() as int[,];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        arr2[0, i] = arr[arr.GetLength(0) - 1, i];
        arr2[arr.GetLength(0) - 1, i] = arr[0, i];
    }
    return arr2;
}