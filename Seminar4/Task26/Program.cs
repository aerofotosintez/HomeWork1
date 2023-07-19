// Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введе целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Count(int number)
{
    int i = 1;
    while (number >= 10)
    {
        number = number / 10;
        i++;
    }
    return i;
}
int number = ReadInt();
int i = Count(number);
Console.WriteLine($"количество цифр в введеном числе: {i}");
