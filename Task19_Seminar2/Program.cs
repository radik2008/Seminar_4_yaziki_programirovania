using static System.Console;                 //написать программу которая принимает число и проверяет на кратность и 7 и 23
Clear();
WriteLine("Введите число: ");
int numb = Convert.ToInt32(ReadLine());
WriteLine(numb % 7 == 0 && numb % 23 == 0 ? "кратно 7 и 23" : "не кратно 7 и 23");
