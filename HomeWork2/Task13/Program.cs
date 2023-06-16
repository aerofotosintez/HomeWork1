// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string n = Console.ReadLine()!;
int N = Convert.ToInt32(n);
if (N < 100)
{
    Console.WriteLine("введите число от трех чисел и более, а не это:");
}
else
{
    for (int a = 999; a < N; N = N / 10);
}
Console.WriteLine(N % 10);