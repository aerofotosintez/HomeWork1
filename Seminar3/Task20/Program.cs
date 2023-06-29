// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Math.Sqrt(x + y) корень
//Math.Pow(x1 - x2, 2) квадрат


Console.WriteLine("введите координату Х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату Х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

double x = Math.Pow(x1 - x2, 2);
double y = Math.Pow(y1 - y2, 2);
double result = Math.Sqrt(x + y);

Console.WriteLine(result);