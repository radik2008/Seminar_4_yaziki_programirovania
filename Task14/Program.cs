using static System.Console;
Clear();

int[] Array = { 23, 243, 3323, 432, 42, 46, 867, 867, 876 };

int count = 0;
int faind = 867;
while (count < Array.Length)
{
    if (Array[count] == faind)
        {
            WriteLine($"{count} номер элемента");
            
        }
    count++;
}
Write(Array.Length);