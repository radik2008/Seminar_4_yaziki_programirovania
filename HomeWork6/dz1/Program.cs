// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

Write("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine());
Write("Введите значение k1:");
double k1 = double.Parse(Console.ReadLine());
Write("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine());
Write("Введите значение k2:");
double k2 = double.Parse(Console.ReadLine());


WriteLine($"координаты перечечения графиков Х= {coordinatesX(b1, k1, b2, k2):f2}");
WriteLine($"координаты перечечения графиков У= {coordinatesY(coordinatesX(b1, k1, b2, k2), b1, k1):f2}");
WriteLine($"({coordinatesX(b1, k1, b2, k2):f2}; {coordinatesY(coordinatesX(b1, k1, b2, k2), b1, k1):f2})");
// double x = coordinatesX(b1, k1, b2, k2);
// // WriteLine($"координаты точки X равно {x:f3}");



double coordinatesX(double B1, double K1, double B2, double K2)
{
    double res = (b2 - b1) / (k1 - k2);
    return res;
}

double coordinatesY(double X, double B1, double K1)
{
    double Y = K1 * X + B1;
    return Y;
}
