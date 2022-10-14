//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine($"Number {number1} is bigger than number {number2}.");
else
    Console.WriteLine($"Number {number2} is bigger than number {number1}.");
*/


//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maximum = number1;
if(number2 > maximum)
    maximum = number2;
if(number3 > maximum)
    maximum = number3;

Console.WriteLine($"Maximum is {maximum}.");
*/


//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine($"Number {number} is even.");
else
    Console.WriteLine($"Number {number} is odd.");
*/

//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

Console.Write("Even numbers are: ");
while(count <= number)
{
    if(count % 2 == 0)
        Console.Write($"{count} ");
    count++;
}
*/