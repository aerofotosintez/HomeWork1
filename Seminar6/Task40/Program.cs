// Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник 
// со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.
Console.WriteLine("введите значение стороны треугольника а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение стороны треугольника b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение стороны треугольника c");
int c= Convert.ToInt32(Console.ReadLine());
int TrangleExists(a, b, c)
{
if(a < 0 || b < 0 || c < 0)
{
    Console.WriteLine("введены неверные значения");
}
else if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Треугольник существует");
    
}
else 
{
    Console.WriteLine("Треугольник не может существовать");

}
}

bool result = TrangleExists();
Console.WriteLine();