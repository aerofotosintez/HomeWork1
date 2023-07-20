// Задайте значения M и N. Напишите программу, которая
//  найдёт сумму натуральных элементов в промежутке 
//  от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int SummaRec(int x, int y)
{
    if(x == y) return n;
    return x + SummaRec(x + 1, y);
}
Console.Write(SummaRec(m, n));