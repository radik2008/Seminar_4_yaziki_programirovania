// ..Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



using static System.Console;
Clear();

Write("Введите размер матрицы  3D и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,,] array1 = GetMatrix3DArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]), (intParams[4]));    //





PrintMatrix3DArray(array1);
WriteLine();



// int[] cubeValues = new int[intParams[0] * intParams[1] * intParams[2]];
// int tmp = 0;
// bool isUnique = false;
// for (int i = 0; i < cubeValues.Length; i++)
// {
//     tmp = rand.Next(intParams[3], intParams[4]);
//     isUnique = true;
//     for (int j = 0; j < cubeValues.Length; j++)
//     {
//         if (cubeValues[j] == tmp) { i--; isUnique = false; break; }
//     }
//     if (isUnique) { cubeValues[i] = tmp; }
// }



int[,,] GetMatrix3DArray(int rows, int columns, int width, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,,] resultArray = new int[rows, columns, width];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < width; k++)
            {
                resultArray[i, j, k] = rnd.Next(minValue, maxValue + 1);
            }

        }
    }
    return resultArray;
}

void PrintMatrix3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k],5}  ({i}, {j}, {k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}
