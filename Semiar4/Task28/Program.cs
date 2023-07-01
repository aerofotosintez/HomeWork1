// Напишите программу, которая принимает
//  на вход число N и выдаёт произведение
//  чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введе целое число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Multiply(int number)
{
int result = 1;
    for (int i = 1; number >= i; i++)
    {
        result = result * i;
    }
    return result;
}
int number = ReadInt();
int multiply = Multiply(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {multiply}");