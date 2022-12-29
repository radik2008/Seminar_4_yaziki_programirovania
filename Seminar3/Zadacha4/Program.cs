//Программа которая по координатам точек определяет растояние между ними
using static System.Console;
Clear();
Write("ВВедите координаты х1 :");
int x1 = int.Parse(ReadLine());
Write("ВВедите координаты y1 :");
int y1 = int.Parse(ReadLine());
Write("ВВедите координаты х2 :");
int x2 = int.Parse(ReadLine());
Write("ВВедите координаты y2 :");
int y2 = int.Parse(ReadLine());
double i = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));

Write($"{i:f2}");   // округление  f2 до десятых, p проценты