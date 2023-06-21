//  Напишите программу, которая принимает на вход координаты точки (X и Y),
//   причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//    в которой находится эта точка.

Console.WriteLine("введите координату по оси Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату по оси Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("четверть "+ 1);
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("четверть "+ 2);
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("четверть "+ 3);
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("четверть "+ 4);
}
else
{
    Console.WriteLine("невозможно определить");
}