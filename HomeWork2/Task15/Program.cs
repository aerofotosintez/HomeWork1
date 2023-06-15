//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("введите день недели числом ");
string numberStringDay = Console.ReadLine()!;
int numberIntDay = Convert.ToInt32(numberStringDay);

if (numberIntDay == 6 || numberIntDay == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}