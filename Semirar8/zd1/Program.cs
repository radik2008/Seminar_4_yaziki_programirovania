// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2


// **Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7



using static System.Console;
using MyLib;
Clear();


int[,] ar = MyMetods.GetMatrixArray(4, 4, 10, 99);
MyMetods.PrintMatrixArray(ar);
WriteLine();

int[,] ar2 = CheangeArray(ar);
MyMetods.PrintMatrixArray(ar2);
WriteLine();

CheangeLineColumn(ar2);


int[,] CheangeArray(int[,] arr)                  // первая задача замена первой и последней строки
{
    int[,] arr2 = arr.Clone() as int[,];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        arr2[0, i] = arr[arr.GetLength(0) - 1, i];
        arr2[arr.GetLength(0) - 1, i] = arr[0, i];
    }
    return arr2;
}

void CheangeLineColumn(int[,] arr)               //вторая задача по замене строк и столбцов
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        WriteLine("Это невозможно!!!");
    }
    else
    {
        int[,] arrNew = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                arrNew[j, i] = arr[i, j];
            }
        }
        MyMetods.PrintMatrixArray(arrNew);
    }
}
    
