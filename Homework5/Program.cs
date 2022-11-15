// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Enter the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n);
ShowArray(myArray);
int counter = CountEven(myArray);
Console.Write($"The number of even numbers in the array is {counter}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumElem(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            sum += array[i];
    }
    return sum;
}

Console.Write("Enter the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, minValue, maxValue);
ShowArray(myArray);
int sum = SumElem(myArray);
Console.Write($"The sum of elements in odd positions is {sum}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1) + Math.Round(new Random().NextDouble(), 2);
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double DiffMinMax(double[] array)
{
    double minimum = double.MaxValue;
    double maximum = double.MinValue;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minimum)
            minimum = array[i];
        if(array[i] > maximum)
            maximum = array[i];
    }
    return Math.Round(maximum - minimum, 2);
}

Console.Write("Enter the size of the array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum integer part of value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum integer part of value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(n, minValue, maxValue);
ShowArray(myArray);
double difference = DiffMinMax(myArray);
Console.Write($"The difference between maximum and minimum elements is {difference}");
*/