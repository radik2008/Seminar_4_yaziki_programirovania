﻿using static System.Console;
Clear();
int number=new Random().Next(10,100);
WriteLine(number);
int a1=number/10;
int a2=number%10;
if(a1>a2)
{
    WriteLine(a1);
}
else
{
   WriteLine(a1); 
}
