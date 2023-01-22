// программа переводит десятичное в двоичное
using static System.Console;
Clear();
WriteLine("Введите число: ");
int.TryParse(ReadLine(), out int num);

WriteLine($"{decitToBinary(num)}");

string decitToBinary(int iNnum)
{
    string result = string.Empty;
    int rem;  //    остаток
    while (iNnum > 0)
    {
        rem = iNnum % 2;
        iNnum = iNnum / 2;
        result = rem.ToString() + result;
    }
    return result;

}


string x = "л1л1л1л";
string x1 = "2л2о2о2о";
string x2 = "д3о3о3о3";
string y = x +x1+x2+num.ToString();           /// складываем строки эксперимент
WriteLine(y);