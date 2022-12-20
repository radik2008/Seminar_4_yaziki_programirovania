using static System.Console;
Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[]Array = {23, 243, 23, 432, 42, 46, 867, 867, 876};

int max = Max(Max(Array[0], Array[1], Array[2]), Max(Array[3], Array[4], Array[5]), Max(Array[6], Array[7], Array[8]));

Write(max);