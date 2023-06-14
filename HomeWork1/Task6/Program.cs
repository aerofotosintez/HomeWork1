// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите первое число:");
string numberStringOne = Console.ReadLine()!;
double numberIntOne = Convert.ToInt32(numberStringOne);

if ((numberIntOne % 2) != 0)
{
    Console.WriteLine("Число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}