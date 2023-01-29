//  Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

int[,] array = GetMatrixArray((intParams[0]), (intParams[1]), (intParams[2]), (intParams[3]));    //


PrintMatrixArray(array);
WriteLine();


CheangeArray(array);
WriteLine();



int[,] CheangeArray(int[,] arra)
{
    int[,] resAr = new int[arra.GetLength(0) - 1, arra.GetLength(1) - 1];
    int min = arra[0, 0];
    int pozitionMinI = 0;
    int pozitionMinJ = 0;
    int afterMinI = 0;
    int afterMinJ = 0;
    for (int i = 0; i < arra.GetLength(0); i++)
    {
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            if (arra[i, j] < min)
            {
                min = arra[i, j];
                pozitionMinI = i;
                pozitionMinJ = j;
            }
        }
    }
    WriteLine($"{min}  позиция элемента {pozitionMinI}, {pozitionMinJ}");

    for (int f = 0; f < resAr.GetLength(0); f++)
    {
        for (int g = 0; g < resAr.GetLength(0); g++)
        {
            if (g < pozitionMinJ)
            {
                afterMinJ = g;
            }
            else
            {
                    afterMinJ = g+1;
            }
                    

            if (f < pozitionMinI)
            {
                afterMinI = f;
            }
            else{
                    afterMinI = f+1;
                }
            resAr[f,g]=arra[afterMinI,afterMinJ];
            
        }
    }
    PrintMatrixArray(resAr);
    return resAr;
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
