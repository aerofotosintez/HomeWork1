// Задайте массив натуральных чисел. Найдите разницу
//  между максимальным и минимальным элементов массива.
//   (не использовать стандартные функции/методы)
// [3 7 22 2 78] -> 76

int[] GetRandomArray()
{
    Console.WriteLine("введите длину массива: ");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine("введите нижнюю границу массива: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите верхнюю границу массива: ");
    int b = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(a, b);
    }
    return array;
}
int[] array = GetRandomArray();
Console.WriteLine($"случайный массив \t {string.Join(", ", array)}");

int min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(min > array[i]) min = array[i];
}
int max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if(max < array[i]) max = array[i];
}

Console.WriteLine($"разница мужду максимальным и минимальным элементами массива = {max - min}");