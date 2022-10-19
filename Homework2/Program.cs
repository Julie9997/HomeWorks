// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondDig(int num)
{
    int result = num % 100 / 10;
    return result;
}

Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = SecondDig(number);

Console.WriteLine($"The second digit is: {res}");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int findThird(int num)
{
    if(num > 99)
    {
        int count = 0;
        int n = num;
        while(num > 999)
        {
            num /= 10;
            count++;
        }
        int div = Convert.ToInt32(Math.Pow(10, count));
        int res = (n / div) % 10;
        return res;
    }
    else
        return -1;
}

Console.Write("Enter a number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = findThird(number);
if(result == -1)
    Console.WriteLine("There is no third digit");
else
    Console.WriteLine($"The third digit is {result}");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool isWeekend(int day)
{
    if(day == 6 || day == 7)
        return true;
    else
        return false;
}

Console.Write("Enter the day numbe: ");
int day = Convert.ToInt32(Console.ReadLine());

bool chill = isWeekend(day);
if(chill)
    Console.WriteLine("It's weekend! You can chill");
else
    Console.WriteLine("Unfortunately it is not weekend");