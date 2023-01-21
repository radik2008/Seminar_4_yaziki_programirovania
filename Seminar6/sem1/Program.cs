// See https://aka.ms/new-console-template for more information

using static System.Console;
Clear();
Write("Введите размер массива: ");
int.TryParse(ReadLine(), out int arraySize);
int[] Ar = GetArra(arraySize);

string StringArray = String.Join(", ", Ar);  // так мы быстро выводим массив на экран
WriteLine($"[{StringArray}]");                // так мы быстро выводим массив на экран

WriteLine($"[{String.Join(", ", ReversOne(Ar))}]"); // так мы быстро выводим массив на экран

ReversTwo(Ar);
WriteLine($"[{String.Join(", ", Ar)}]");

// WriteLine($"[{String.Join(", ", ReversTwo(Ar))}]");

int[] GetArra(int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next(1, 10);
    }
    return Array;
}

int[] ReversOne(int[] Ar)//                    способ развернуть массив с созданием нового массива
{
    int[] res = new int[Ar.Length];
    for (int i = 0; i < Ar.Length; i++)
    {
        res [i]=Ar[Ar.Length-1-i];
    }
    return res;
}

void ReversTwo(int[] Ar)//                    способ развернуть массив с перезаписью массива
{
    for (int i = 0; i < Ar.Length/2; i++)
    {
        int Temp=Ar[i];
        Ar[i]=Ar[Ar.Length-1-i];
        Ar[Ar.Length-1-i]= Temp;
        
    }
    
}


