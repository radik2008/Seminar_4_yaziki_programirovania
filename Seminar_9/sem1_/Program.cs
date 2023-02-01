
// Собрать строчку с числами от а до б    первое условие a<b и второе a>b

using static System.Console;
Clear();

string NumbFor(int a, int b)   /// через цикл а<b
{
    string res = String.Empty;
    for (int i = a; i <= b; i++)
    {
        res += $"{i}  ";
    }
    return res;
}

string NumbRec(int a, int b)          /// чере рекурсию а<b         добавляем по числу справа
{
    if (a <= b) return $"{a}  " + NumbRec(a + 1, b);
    else return String.Empty;
}

WriteLine(NumbFor(1, 10));
WriteLine(NumbRec(1, 10));

WriteLine(NumbFor2(10, 1));
WriteLine(NumbRec2(1, 10));

PrintNumbers(30, 20);
WriteLine();
PrintNumbers(30, 40);

string NumbFor2(int a, int b)   /// через цикл а>b
{
    string res = String.Empty;
    for (int i = a; i >= b; i--)
    {
        res += $"{i}  ";
    }
    return res;
}

string NumbRec2(int a, int b)          /// чере рекурсию а>b
{
    if (a <= b) return NumbRec2(a + 1, b) + $"{a} "; /// из за долбаеба препода, код через жопу, добавляем по числу слева
    else return String.Empty;
}



void PrintNumbers(int a, int b)                  /// чере воид метод
{
    if (a <= b)  

        if (a == b) Write($" {b}");
        else
        {
            PrintNumbers(a, b - 1);
            Write($", {b}");
        }
    else
    {
        if (a == b) Write($" {b}");
        else
        {
            Write($" {a},");
            PrintNumbers(a-1, b);
        }
    }
}





