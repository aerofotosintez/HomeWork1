// Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int c = 1; c<=b; c++)
{
    double a = Math.Pow(c, 3);
    Console.WriteLine(a);
}