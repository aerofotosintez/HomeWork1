// Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.WriteLine("введите длину массива: ");
//  int n = Convert.ToInt32(Console.ReadLine());

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

void ReverseArray(int[] surseArray)
{
    for(int i = 0; i < surseArray.Length / 2; i++)
    {
        int temp = surseArray[i];
        surseArray[i] = surseArray[surseArray.Length - i - 1];
        surseArray[surseArray.Length - i - 1] = temp;
    }
}

int[] myArray = GetRandomArray(5, -9, 10);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));
