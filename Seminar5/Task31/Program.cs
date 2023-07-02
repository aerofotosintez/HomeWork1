// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и
//  положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма 
// отрицательных равна -20.

int[] GetRandomArray()
{
    int[] array = new int[12];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int SumPositiveElements(int[] massive)
{
    int sumOfPositiveElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] > 0)
        {
            // sumOfPositiveElements  = sumOfPositiveElements + massive[i]
            sumOfPositiveElements += massive[i];
        }
    }
    return sumOfPositiveElements;
}

int SumNegativeElements(int[] massive)
{
    int sumOfNegativeElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] < 0)
        {
            // sumOfNegativeElements  = sumOfNegativeElements + massive[i]
            sumOfNegativeElements  += massive[i];
        }
    }
    return sumOfNegativeElements;
}

int[] myArray = GetRandomArray();
int sumPositive = SumPositiveElements(myArray);
int sumNegative = SumNegativeElements(myArray);
// string.Join выводит массив в одну строку
Console.WriteLine($"{string.Join(",", myArray)}"); 
Console.WriteLine($"сумма положительных элементов = {sumPositive}");
Console.WriteLine($"сумма отрицательных элементов = {sumNegative}");
