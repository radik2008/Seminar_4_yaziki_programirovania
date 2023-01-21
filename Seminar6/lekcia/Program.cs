// создание и заполнение матрицы
using static System.Console;
Clear();

void PrintArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 Write($"{matr[i, j]} ");
 }
WriteLine();
 }
}

void FillArray(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
 matr[i,j] = new Random().Next(1,10);//[1; 10)
 }
 }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
WriteLine();
PrintArray(matrix);
