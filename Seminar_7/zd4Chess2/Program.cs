// Какого цвета клетка шахматной доски, если начинается с черной


using static System.Console;

Clear();
Write("Введите координаты клетки через пробел: ");

string parametrs = ReadLine();
int param1 = parametrs[0];    ////////////  используем номер символа, тип данных чар
int param2 = parametrs[1];

WriteLine(param1);
WriteLine(param2);

if((param1+param2)%2==0)
    {
        Write("Клетка черная");
    }
else
    {
        Write("Клетка белая");
    }