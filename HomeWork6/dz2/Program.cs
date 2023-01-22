// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);  // вместо " " можно написать new char[]{' ', ':', '#'  } и перечислить все разделители


// string StringArray = String.Join(", ", Ar);  // так мы быстро выводим массив на экран
// WriteLine($"[{StringArray}]");                // так мы быстро выводим массив на экран

WriteLine($"[{String.Join(", ", array)}]"); // так мы быстро выводим массив на экран
WriteLine($"Количество чисел больше 0 равно {Count(array)}");
int Cou=Count(array);
WriteLine(Cou);

int Count(string[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (double.Parse(item) > 0) count++;

    }
    return count;
}
