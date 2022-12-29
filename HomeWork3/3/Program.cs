// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using static System.Console;
Clear();
Write("ВВедите координаты х1 :");
int x1 = int.Parse(ReadLine());
Write("ВВедите координаты y1 :");
int y1 = int.Parse(ReadLine());
Write("ВВедите координаты z1 :");
int z1 = int.Parse(ReadLine());

Write("ВВедите координаты х2 :");
int x2 = int.Parse(ReadLine());
Write("ВВедите координаты y2 :");
int y2 = int.Parse(ReadLine());
Write("ВВедите координаты z2 :");
int z2 = int.Parse(ReadLine()); 

double i = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));

WriteLine($"{i:f2}");   // округление  f2 до десятых, p проценты
Write(i+"dddd");     //добавить текст
