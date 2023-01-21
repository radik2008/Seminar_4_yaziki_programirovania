//задача1 програма получает 3 числа и проверяет возможен ли такой треугольник 
using static System.Console;
Clear();

Write("Введите 3 чмсла, стороны треугольника через через пробел: ");
string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);  // вместо " " можно написать new char[]{' ', ':', '#'  } и перечислить все разделители




WriteLine(Check(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]))?"нет":"да");

bool Check(int a, int b, int c )
// // {
// //     if (a+b<=c|| a+c<=b || c+b<=a) return true;
   
// //     return false;
// }
{
    return (a+b<=c|| a+c<=b || c+b<=a);  //сократив все что выше расписал
}