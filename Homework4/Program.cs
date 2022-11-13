//Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int NumPow(int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
        result *= A;
    return result;
}

Console.Write("Enter the number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the power B: ");
int B = Convert.ToInt32(Console.ReadLine());
int powed = NumPow(A, B);
Console.WriteLine($"The number {A} to the power of {B} is equal to {powed}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*
int DigitSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitSum(number);
Console.WriteLine($"The sum of digits in number {number} is equal to {sum}");
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Enter the {i+1} member of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Enter the size of the array: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(m);
Console.WriteLine();
ShowArray(myArray);
*/