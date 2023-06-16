// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное число ");
string numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
Console.WriteLine((numberInt /10) % 10);