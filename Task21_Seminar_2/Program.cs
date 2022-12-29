// два стрелка стреляют по очереди по банкам, в конце оба одновременно сбили банку, сколько было банок
using static System.Console;
Clear();
WriteLine("Введите количество банок первого стрелка:");
int num1 = Convert.ToInt32(ReadLine());
WriteLine("Введите количество банок второго стрелка: ");
int num2 = Convert.ToInt32(ReadLine());
WriteLine($"Общее количество банок {num1 + num2 -1}");


