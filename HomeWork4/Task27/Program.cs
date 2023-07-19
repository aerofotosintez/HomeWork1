// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt( string message)
{
    System.Console.Write(message);
    string? readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumIchDigit(int number)
{
int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = ReadInt("введите число: ");
System.Console.WriteLine($"сумма всех цифр в числе {number} = {SumIchDigit(number)}");