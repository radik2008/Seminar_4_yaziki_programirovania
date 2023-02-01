
// Вычислить А в степени n
using static System.Console;
Clear();

int PowerFor(int a, int n)   /// через цикл
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= a;
    }
    return res;
}

int PowerRec(int a, int n)          /// чере рекурсию 
{
    if (n == 0) return 1;
    else return PowerRec(a, n-1)*a;
}


WriteLine(PowerFor(9, 5));
WriteLine(PowerRec(5, 7));




