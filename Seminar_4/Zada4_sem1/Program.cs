// написать программу котораяя принимает число А и выдает сумму от 1 до А   
// написать программу котораяя принимает число А и выдает произведени  от 1 до А   

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

WriteLine("Введите число: ");
WriteLine();
int count = int.Parse(ReadLine());
int sum = GetSum(count);
int proiz = GetProizvedenie(count);
WriteLine();
WriteLine($"сумма чисел от 1 до А равна {sum}");
WriteLine();
WriteLine($"произведение чисел от 1 до А равна {proiz}");
WriteLine();