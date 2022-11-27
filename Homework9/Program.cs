// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNums(int N)
{
    Console.Write(N + " ");
    if(N > 1) ShowNums(N - 1);
}

Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNums(N);
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SumFromMtoN(int M, int N)
{
    if(M < N) 
        return SumFromMtoN(M + 1, N) + M;

    if(M > N)
        return SumFromMtoN(M, N + 1) + N;
    else
        return M;

}

Console.Write("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumFromMtoN(M, N);
Console.Write($"The sum of numbers from M to N is: {sum}");
*/


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
int AckermannFunction(int m, int n)
{
    if(m == 0)
        return n + 1;
    else if(m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

int ackermannFunc = AckermannFunction(m, n);
Console.Write($"A({m}, {n}) = {ackermannFunc}");
*/