﻿using static System.Console;
WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if(b > max) max = b;
if(c > max) max = c;
WriteLine($"Максимальное число {max}");