// *Задача 57:**Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза




using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //


PrintMatrixArray(array);
WriteLine();

Distionary(array);
WriteLine();



void Distionary(int[,] arra)
{
    for (int r = 0; r < 10; r++)
    {
        int n = 0;

        for (int i = 0; i < arra.GetLength(0); i++)
        {
            for (int j = 0; j < arra.GetLength(1); j++)
            {
                if (arra[i, j] == r) n ++;
                
            }
        }
        WriteLine($"Число {r} встречаетс {n} раз!");
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
