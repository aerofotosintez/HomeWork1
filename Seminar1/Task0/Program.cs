﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число:"); //"123" -> 123
string numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
Console.WriteLine(numberInt * numberInt);

