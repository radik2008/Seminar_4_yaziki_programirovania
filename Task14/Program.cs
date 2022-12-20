using static System.Console;
Clear();

int[] Array = { 23, 243, 23, 432, 42, 46, 867, 867, 876 };

int count = 0;
int faind = 42;
while (count < Array.Length)
{
    if (Array[count] == faind) Write($"{count} номер элемента");
    count++;
}

