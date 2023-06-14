// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
string numberStringOne = Console.ReadLine()!;
int numberIntOne = Convert.ToInt32(numberStringOne);

Console.WriteLine("Введите второе число:");
string numberStringTwo = Console.ReadLine()!;
int numberIntTwo = Convert.ToInt32(numberStringTwo);

Console.WriteLine("Введите третье число:");
string numberStringThree = Console.ReadLine()!;
int numberIntThree = Convert.ToInt32(numberStringThree);

var max = numberIntOne;
if(max < numberIntTwo)
{
    max = numberIntTwo;
}
if(max < numberIntThree)
{
    max = numberIntThree;
}

    Console.WriteLine($"MAX из трех чисел: {max}");
    Console.ReadLine ();