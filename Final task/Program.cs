// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//     Примеры:
//     ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//     ["1234", "1567", "-2", "computer science"] -> ["-2"]
//     ["Russia", "Denmark", "Kazan"] -> []


using static System.Console;
Clear();

// Первый вариан когда данн готовый массив
WriteLine("Первый вариан когда данн готовый массив");
WriteLine();

string[] inputArray1 = { "hello", "my", "world", "and", "goodbay" };              
string[] inputArray2 = { "1234", "1567", "-2", "132", "+323" };
string[] inputArray3 = { "Russia", "Spain", "Kazan", "France", "Italy", "Ukraine" };

string[] array1 = ChangeArry(inputArray1, 3);
string[] array2 = ChangeArry(inputArray2, 3);
string[] array3 = ChangeArry(inputArray3, 3);

WriteLine($"[{String.Join(", ", (inputArray1))}]");
WriteLine($"[{String.Join(", ", (inputArray2))}]");
WriteLine($"[{String.Join(", ", (inputArray3))}]");

WriteLine();

WriteLine($"[{String.Join(", ", (array1))}]");
WriteLine($"[{String.Join(", ", (array2))}]");
WriteLine($"[{String.Join(", ", (array3))}]");
WriteLine();

// Второй вариан когда вводим масив с клавиатуры массив
WriteLine("Второй вариан когда вводим масив с клавиатуры массив");
WriteLine();

Write("Введите элементы массива через пробел, цифры, буквы, знаки: ");
string[] UserArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine();

WriteLine($"[{String.Join(", ", (ChangeArry(UserArray,3)))}]");


string[] ChangeArry(string[] arrayText, int maxSymbol)
{
    int arSize = 0;
    for (int i = 0; i < arrayText.Length; i++)
    {
        if (arrayText[i].Length <= maxSymbol)
        {
            arSize++;
        }
    }

    string[] resArr = new string[arSize];
    int num = 0;
    for (int j = 0; j < arrayText.Length; j++)
    {
        if (arrayText[j].Length <= maxSymbol)
        {
            resArr[num] = arrayText[j];
            num = num + 1;
        }
    }
    return resArr;
}
