//Программа которая по координатам х и у определяет четверть
using static System.Console;
Clear();
Write("ВВедите координаты х :");
int x = int.Parse(ReadLine());
Write("ВВедите координаты y :");
int y = int.Parse(ReadLine());
Write(x>0 && y>0?"первая":x>0 && y<0?"четвертая":x<0 && y>0?"вторая":x<0 && y<0?"третья":"ошибка");
