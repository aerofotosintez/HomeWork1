// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
for(int j = 0; j < array.Length; j++)
{
    Console.WriteLine($"введите {j} элемент массива");
    array[j] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write("{0} ", array[i]);
}

