//задача перемножить парами элементы массива, первый и последний, второй и предпоследний и т д
using static System.Console;
Clear();

Write("Введите крайний верхний диапозон значения массива:");
int a = int.Parse(Console.ReadLine());
Write("Введите крайний нижний диапозон значения массива:");
int b = int.Parse(Console.ReadLine());
Write("Введите длинну массивва:");
int с = int.Parse(Console.ReadLine());

int[] array = new int[с];

FillArray(array);
PrintArray(array);
int[] array2 = Proiz(array);
WriteLine();
PrintArray(array2);



int[] Proiz(int[]AR)
{
    int size = AR.Length/2;
    if (size/2 == 1) size++;

    int[] AR2 = new int[size];

    for (int i = 0; i < size; i++)
    {
        AR2[i] = AR[i]*AR[AR.Length-1-i];
    }
    return AR2;
}


void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(b, a);
    }

}

void PrintArray(int[] Ar)
{
     Write("[");
    for (int i = 0; i < Ar.Length - 1; i++)
    {
        Write($"{Ar[i]}, ");
    }
    Write($"{Ar[Ar.Length - 1]}]");

}