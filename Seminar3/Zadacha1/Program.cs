// вводим номер дня, получаем название дня недели, использую свич кейс
using static System.Console;
Clear();
Write("ВВедите число от 1 до 7:");
int day = int.Parse(ReadLine());
switch (day)
{
    case 1:
        {
            WriteLine("Понедельник");
            break;
        }
    case 2:
        {
            WriteLine("Вторник");
            break;
        }
    case 3:
        {
            WriteLine("среда");
            break;
        }
    case 4:
        {
            Write("Четверг");
            break;
        }
    case 5:
        {
            Write("Пятница");
            break;
        }
    case 6:
        {
            Write("Суббота");
            break;
        }
    case 7:
        {
            Write("Воскресенье");
            break;
        }
        default:
        {
            Write("Ощибка");
            break;
        }
}
