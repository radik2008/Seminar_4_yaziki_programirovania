// написать программу котораяя принимает число А и выдает сумму от 1 до А   
// написать программу котораяя принимает число А и выдает произведени  от 1 до А   
//написать программу котораяя принимает число А и выдает сумму от 1 до А на которые А делиться без остатка

using static System.Console;
Clear();
WriteLine("Hello, World!");

int GetSum(int A)

{
    int result = 0;
    while (A > 0)
    {
        result += A;
        A--;  // вычитать по одному
    }
    return result;
}

int GetProizvedenie(int A)
{
    int result = 1;
    while (A > 0)
    {
        result *= A;
        A--;  // вычитать по одному
    }
    return result;
}

int GetSumNot(int A)
{
    int result = 0;
    int i = 1;
    while (i < A)
    {
        if (A % i == 0)
        {
            result = result + i;
        }
        i++;
    }

    return result;
}

WriteLine("Введите число: ");
WriteLine();
int count = int.Parse(ReadLine());
int sum = GetSum(count);
int proiz = GetProizvedenie(count);
int sum2 = GetSumNot(count);
WriteLine();
WriteLine($"сумма чисел от 1 до А равна {sum}");
WriteLine();
WriteLine($"произведение чисел от 1 до А равна {proiz}");
WriteLine();
WriteLine($"сумма чисел от 1 до А равна которые деляться без остатка {sum2}");