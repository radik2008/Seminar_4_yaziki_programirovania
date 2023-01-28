// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //


PrintMatrixArray(array);
WriteLine();

double [] array2  = AverageColumns(array);
WriteLine();

WriteLine($"среднее арифметическое колон [{String.Join("  ", array2)}:f2]");

PrintArray(array2);


double[] AverageColumns(int[,] arra)
{
    double[] res = new double[arra.GetLength(1)];
    
    for (int j = 0; j < arra.GetLength(1); j++)
    {
        double n = 0;
        for (int i = 0; i < arra.GetLength(0); i++)
        {
            n += arra[i, j];
        }
        res[j] = (n/arra.GetLength(0));
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

void PrintArray(double[] Ar)
{
     Write("[");
    for (int i = 0; i < Ar.Length - 1; i++)
    {
        Write($"{Ar[i]:f3}  ");
    }
    Write($"{Ar[Ar.Length - 1]:f3}]");

}
