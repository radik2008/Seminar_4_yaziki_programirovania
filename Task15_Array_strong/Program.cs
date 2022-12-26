using static System.Console;
Clear();

void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int position=0;
    while (position < col.Length)
    {
        WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
