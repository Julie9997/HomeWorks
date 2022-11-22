//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1) + Math.Round(new Random().NextDouble(), 2);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum possible integer part of value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum possible integer part of value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


/*
bool isInArray(int[,] array, int row, int col)
{
    if(row < array.GetLength(0) && col < array.GetLength(1))
        return true;
    else return false;
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);

Console.Write("Input row number: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column number: ");
int colNum = Convert.ToInt32(Console.ReadLine());
if(isInArray(myArray, rowNum, colNum))
{
    int foundedNumber = myArray[rowNum, colNum];
    Console.WriteLine($"You were looking for a number on the position [{rowNum}][{colNum}], and it is: {foundedNumber}");
}
else
    Console.WriteLine($"The position [{rowNum}][{colNum}] doesn't exist in this array");
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
double[] ArrayColumnAvgs(int[,] array)
{
    double[] ColAvgs = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
       double avg = Math.Round(sum/array.GetLength(0), 2);
       ColAvgs[j] = avg;
    }
    return ColAvgs;
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue+1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, minValue, maxValue);
Show2dArray(myArray);

Console.WriteLine("Average values of columns are: ");
double[] avgs = ArrayColumnAvgs(myArray);
ShowArray(avgs);
*/