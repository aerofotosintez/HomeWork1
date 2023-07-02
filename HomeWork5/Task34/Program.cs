// Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray()
{
    Console.WriteLine("введите длину массива: ");
    int[] array = new int[Convert.ToInt32(Console.ReadLine())];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}
int[] array = GetRandomArray();
Console.WriteLine($"случайный массив \t {string.Join(", ", array)}");
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) 
    count++;
}
Console.WriteLine($"колличество четных чисел в массиве \t {count}");