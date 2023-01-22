// Нахождение факториала   и фиборачи, чрез рекурсию
Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

int Factorial(int n)                                  ///   через рекурсию
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n= n * Factorial(n-1);
}
for (int i = 1; i <= num; i++) Console.WriteLine($"{i}! = {Factorial(i)}");

Console.WriteLine();


int Fibonacci(int n)                                    ///   через рекурсию
{
 if(n == 1 || n == 2) return 1;
 else return n = Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i <= num; i++)Console.WriteLine($"f({i}) = {Fibonacci(i)}");

Console.WriteLine($"фибоначи от {num} равно {Fibo(num)}");
for (int i = 1; i <= num; i++)Console.WriteLine($"f({i}) = {Fibo(i)}");

int Fibo( int n)
{
    if(n == 1 || n == 2) return 1;    ///вернуть сразу 1 
    int res = 1;
    int [] arr = new  int[n]; 
        arr[0]=1;
        arr[1]=1;

        for (int i = 2; i < n; i++)
        {
            arr[i]=arr[i-1]+arr[i-2];
            res = arr[i];
        }
        return res;
}    