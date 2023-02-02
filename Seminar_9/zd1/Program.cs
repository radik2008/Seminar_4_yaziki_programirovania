// **Задача 63:** Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.


using static System.Console;
Clear();

string result= GetNumbers1(20);
WriteLine();

WriteLine(result);

WriteLine(GetNumbers1(20));

PrintNumbers(20);

string GetNumbers(int num)
{
    if (num == 1) return num.ToString();
    else return $"{GetNumbers(num - 1)},{num}";
}

string GetNumbers1(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumbers1(num - 1)},{num}";
}

void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        PrintNumbers(num - 1);
        Write($",{num}");
    }
}