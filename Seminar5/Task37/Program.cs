// Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний элемент,
//  второй и предпоследний и т.д. Результат запишите 
//  в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

 
 Console.WriteLine("введите длину массива: ");
 int n = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray()
{
    int[] array = new int[n];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 10);
    }
    return array;
}
int[] massive = GetRandomArray();
// int[] array = GetRandomArray();
// Console.WriteLine($"массив {string.Join(",", array)}");
Console.WriteLine($"случайный массив \t {string.Join(",", massive)}");

int[] revers = new int[(massive.Length + 1) / 2];

for(int i = 0; i < revers.Length; i++ )
{
    revers[i] = massive[i] * massive[massive.Length - 1 - i];
}

if(massive.Length % 2 != 0)
{
    revers[revers.Length - 1] = massive[massive.Length / 2];
}
Console.WriteLine($"перемноженные пары \t {String.Join(",", revers)}");
