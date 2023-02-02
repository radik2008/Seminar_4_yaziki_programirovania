// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


using static System.Console;
Clear();


WriteLine("Введите число первое число:");
int.TryParse(ReadLine(), out int num1);

WriteLine("Введите число второе число:");
int.TryParse(ReadLine(), out int num2);

WriteLine($"сумма  чисел от {num1} до {num2} равна {SumNum1(num1, num2)}");

WriteLine($"сумма  чисел от {num1} до {num2} равна {SumNum2(num1, num2)}");

int SumNum1(int a1, int b1)
{
    if (a1 == b1) return a1;
    else return SumNum1(a1, b1-1) + b1;
}

int SumNum2(int a2, int b2)
{
    if (a2 == b2) return b2;
    else return SumNum2(a2 + 1 , b2) + a2;
}



