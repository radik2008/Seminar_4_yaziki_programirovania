using System.Threading;
// в случайных точках консоли вывести случайные числа
Console.Clear();
Random r = new Random();
Console.CursorVisible = false;
while (true)
{
    Console.SetCursorPosition(     //  метод обрашения к позиции нв экране
        left: r.Next(Console.WindowWidth),           //  обрашение по ширине
        top: r.Next(Console.WindowHeight)    //  обрашение по высоте
    );
    Console.Write(r.Next(10));
    Thread.Sleep(100);   // задержка по времени
}