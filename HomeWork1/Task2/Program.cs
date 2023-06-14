// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
string numberStringOne = Console.ReadLine()!;
int numberIntOne = Convert.ToInt32(numberStringOne);

Console.WriteLine("Введите второе число:");
string numberStringTwo = Console.ReadLine()!;
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if(numberIntOne > numberIntTwo)
{
    Console.Write("MAX= ");
    Console.Write (numberIntOne);
}
else
{
    Console.Write("MAX= ");
    Console.Write (numberIntTwo);
}