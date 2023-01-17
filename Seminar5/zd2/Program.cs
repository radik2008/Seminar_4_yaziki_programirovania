//задача написать программу которая изменяет значения элементов массива на противоположные
using static System.Console;
Clear();

Write("Введите размер массива, мин и макс значение через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);  // вместо " " можно написать new char[]{' ', ':', '#'  } и перечислить все разделители

int[] array = GetArr(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
PrintArray(array);
WriteLine();
ChangeArr(array);
PrintArray(array);

Write("Введите искомый элемент: ");
int.TryParse(ReadLine(), out int looc);
LokingElement(array);

void LokingElement(int[]arra, int loocing)
{
    foreach (int item in arra)
    {
        if(arra[item]=loocing)
        {
            WriteLine("Нужный элемент найден");
        }
        else
        {
            WriteLine("Нужный элемент не найден");
        }
    }
}

void ChangeArr(int[]arra)
{
    for (int i = 0; i < arra.Length; i++)
    {
        arra[i]=arra[i]*(-1);
    }
}

int[] GetArr(int size, int min, int max)
{
    int[] Result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        Result[i] = rnd.Next(min, max + 1);
    }
    return Result;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]}, ");
    }
    Write($"{arr[arr.Length - 1]}]");
}