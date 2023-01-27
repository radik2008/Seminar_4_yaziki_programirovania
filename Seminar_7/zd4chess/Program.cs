// Какого цвета клетка шахматной доски, если начинается с черной

// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

using static System.Console;

Clear();
Write("Введите координаты клетки через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse); // сразу перевели строчку в масив из чисел

ChessColor( intParams[0], intParams[1] );    //  простое решение


WriteLine();






void ChessColor(int x, int y)
{

            if((x+y)%2==0)
            {
                Write("Клетка черная");
            }
            else
            {
                Write("Клетка белая");
            }
        
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