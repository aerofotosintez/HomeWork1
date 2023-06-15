// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число:");
string numberStringOne = Console.ReadLine()!;
int numberIntOne = Convert.ToInt32(numberStringOne);

Console.WriteLine("Введите второе число:");
string numberStringTwo = Console.ReadLine()!;
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if(numberIntOne * numberIntOne == numberIntTwo || numberIntTwo * numberIntTwo == numberIntOne)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}