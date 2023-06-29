// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("введите координату Х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату Х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Pow(x2 - x1, 2);
double y = Math.Pow(y2 - y1, 2);
double z = Math.Pow(z2 - z1, 2);
double result = Math.Sqrt(x + y + z);
// округление результата до 2-х знаков
Console.WriteLine($"{result:f2}");