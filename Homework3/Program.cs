//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool is_palindrome(int number)
{
    bool res = true;
    int pal = number;
    int reverse = 0;
    while(pal > 0)
    {
        int digit = pal % 10;
        reverse = reverse * 10 + digit;
        pal /= 10;
    }
    if(number != reverse)
        res = false;
    return res;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(is_palindrome(number))
    Console.WriteLine($"{number} is a palindrome");
else
    Console.WriteLine($"{number} is not a palindrome");
*/


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double countDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Pow((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)), 0.5);
    return Math.Round(distance, 2);
}

Console.WriteLine("Enter the coordinates of poin A");
Console.Write("x: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinates of poin B");
Console.Write("x: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = countDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"The distance between point A and point B is: {distance}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}
*/