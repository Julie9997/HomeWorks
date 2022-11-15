// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.Write("Enter the number of numbers: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;

for(int i = 0; i < M; i++)
{
    Console.Write($"Enter the number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number > 0)
        count++;
}

Console.Write($"The number of positive numbers entered is {count}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindPoint(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Straight lines match");
    else if(k1 == k2 && b1 != b2)
        Console.WriteLine("Straight lines are paralel. No intersection points");
    else
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 2);
        double y = Math.Round(k1 * x + b1);
        Console.WriteLine($"The point of intersection of y = {k1} * x + {b1} and y = {k2} * x + {b2} is ({x}, {y})");
    }
}


Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k1: ");
double k2 = Convert.ToDouble(Console.ReadLine());

FindPoint(b1, k1, b2, k2);