// скопировать массив через метод
using static System.Console;
Clear();
Write("Введите размер массива: ");
int.TryParse(ReadLine(), out int arraySize);
int[] Ar = GetArra(arraySize);

string StringArray = String.Join(", ", Ar);  // так мы быстро выводим массив на экран
WriteLine($"[{StringArray}]");                // так мы быстро выводим массив на экран




WriteLine($"копия [{String.Join(", ", CopyAr(Ar))}]");

int[] GetArra(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 10);
    }
    return Array;
}

int[] CopyAr(int[] Ar)                           //                    копия массива на осонове создания нового
{
    int[] arr = new int [Ar.Length];
    for (int i = 0; i < Ar.Length; i++)
    {
        arr[i]=Ar[i];
    }
    return arr;
}
        