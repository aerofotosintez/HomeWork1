// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет

Console.WriteLine("Введите первое число:");
string numberStringOne = Console.ReadLine()!;
int numberIntOne = Convert.ToInt32(numberStringOne);

Console.WriteLine("Введите второе число:");
string numberStringTwo = Console.ReadLine()!;
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if(numberIntOne * numberIntOne == numberIntTwo)
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
    Console.WriteLine("первое число не является квадратом второго");
}

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
switch (numberInt)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    case 8: Console.WriteLine("ВВедите число от 1 до 7"); break;
}
Console.ReadLine();