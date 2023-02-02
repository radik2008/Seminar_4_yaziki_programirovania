// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using static System.Console;
Clear();


WriteLine("Введите число первое число:");
int.TryParse(ReadLine(), out int m);

WriteLine("Введите число второе число:");
int.TryParse(ReadLine(), out int n);


WriteLine(Akk(m, n));

WriteLine(ack(m, n));



static int Akk(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }

    else if ((b == 0) && (a > 0))
    {
        return Akk(a - 1, 1);
    }
        else if ((a > 0) && (b > 0))
    {
        return Akk(a - 1, Akk(a, b - 1));
    }
    else return b + 1;
}



static int ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((n == 0) && (m > 0))
    {
        return ack(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return ack(m - 1, ack(m, n - 1));
    }
    else return n + 1;
}