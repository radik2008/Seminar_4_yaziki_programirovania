// **Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9  ...


using static System.Console;
Clear();


WriteLine("Введите число :");
int.TryParse(ReadLine(), out int num);
WriteLine($"сумма  цифр {num} равна {SumNum(num)}");

int SumNum(int n)
{
    if (n == 0) return 0;
    else return SumNum(n/10) + n%10;
}



