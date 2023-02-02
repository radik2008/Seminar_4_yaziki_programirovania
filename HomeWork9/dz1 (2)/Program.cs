// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



using static System.Console;
Clear();


WriteLine(GetNumbers1(20));                //// 1способ

WriteLine(GetNumbers2(20));                    //// 2способ  

PrintNumbers(20);                                     //// 3способ

string GetNumbers1(int num)
{
    if (num == 1) return num.ToString();
    else return $"{num}, {GetNumbers1(num - 1)}";
}

string GetNumbers2(int num)
{
    return (num == 1) ? num.ToString() : $"{num}, {GetNumbers2(num - 1)}";
}

void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        Write($"{num}, ");
        PrintNumbers(num - 1);
    }
}