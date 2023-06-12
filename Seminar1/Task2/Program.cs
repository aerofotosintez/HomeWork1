// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("введите число: ");
String? n = Console.ReadLine();
int b = Convert.ToInt32(n);
for (int c = -b; c<=b; c++)
{
    Console.WriteLine(c);
}