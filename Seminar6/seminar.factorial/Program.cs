// Нахождение факториала   и фиборачи, чрез рекурсию


int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n= n * Factorial(n-1);
}
for (int i = 1; i < 10; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}

Console.WriteLine();


int Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return n = Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++)
{
 Console.WriteLine($"{i}fibo = {Fibonacci(i)}");
}