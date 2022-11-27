//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
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

void ArraySort(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1)-1; j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,j] < array[i, k])
                    {
                        int temp = array[i,j];
                        array[i,j] = array[i,k];
                        array[i,k] = temp;
                    }
            }
        }
    }
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

Console.WriteLine("Sorted array:");
ArraySort(myArray);
Show2dArray(myArray);
*/



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
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

int MinSumRow(int[,] array)
{
    int minimum = Int32.MaxValue;
    int minimumRow = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0; 
        for(int j = 0; j < array.GetLength(1); j++)
            sum += array[i,j];
        if(sum < minimum)
        {
            minimum = sum;
            minimumRow = i+1;
        }
    }
    return minimumRow;
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

int minRow = MinSumRow(myArray);
Console.WriteLine($"The row with the minimum sum of elements is: {minRow}");
*/



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
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
            Console.Write("{0}\t", array[i,j]);
        
        Console.WriteLine();
    }
    Console.WriteLine();
}


void MatrixMultiply(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for(int i = 0; i < matrix1.GetLength(0); i++)
            for(int j = 0; j < matrix2.GetLength(1); j++)
                for(int m = 0; m < matrix2.GetLength(0); m++)
                    matrixResult[i,j] += matrix1[i,m] * matrix2[m,j];
        Console.WriteLine("The result of multiplying two matrices:");
        Show2dArray(matrixResult);
    }
    else
        Console.WriteLine("Multiplication of the given matrices is not possible.");
}

Console.WriteLine("Create the first matrix: ");
Console.Write("Input a number of rows: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum possible value: ");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum possible value: ");
int maxValue1 = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = CreateRandom2dArray(m1, n1, minValue1, maxValue1);
Show2dArray(firstMatrix);

Console.WriteLine("Create the second matrix: ");
Console.Write("Input a number of rows: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum possible value: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum possible value: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

int[,] secondMatrix = CreateRandom2dArray(m2, n2, minValue2, maxValue2);
Show2dArray(secondMatrix);

MatrixMultiply(firstMatrix, secondMatrix);
*/



//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


/*
int[,,] Random3dArray(int x, int y, int z, int minValue, int maxValue)
{
    if(maxValue + 1 - minValue <= x*y*z)
    {
        int[,,] nullArray = new int[0,0,0];
        Console.WriteLine("It is impossible to fill an array with such parameters");
        return nullArray;
    }

    int[,,] array = new int[x, y, z];
    for(int i = 0; i < x; i++)
        for(int j = 0; j < y; j++)
        {
            int k = 0;
            while (k < z)
            {
                int element = new Random().Next(minValue, maxValue + 1);
                if (IsRepeatable(array, element)) continue;
                array[i, j, k] = element;
                k++;
            }
        }    
    return array;
}

bool IsRepeatable(int[,,] array, int elem)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == elem) return true;
            }
        }
    }
    return false;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            { 
                Console.Write("{0}\t", array[i,j,k]  + $" ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Create the array: ");
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimum possible value: ");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum possible value: ");
int maxValue1 = Convert.ToInt32(Console.ReadLine());


int[,,] array3d = Random3dArray(x, y, z, minValue1, maxValue1);
Show3dArray(array3d);
 */


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


/*
 int[,] SnailArray(int n)
 {
    int[,] array = new int[n, n];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= n * n)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < n - 1)
            ++j;
        else if (i < j && i + j >= n - 1)
            ++i;
        else if (i >= j && i + j > n - 1)
            --j;
        else
            --i;
        ++num;
    }
    return array;
 }

 void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
                Console.Write("0{0} ", array[i,j]);
            else
                Console.Write("{0} ", array[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Enter n for the array with size n x n: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And here we have a snailed array:\n");
Show2dArray(SnailArray(size));
*/