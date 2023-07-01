// Напишите функцию, которая принимает на
//  вход два числа (A и B) и возводит 
//  число A в натуральную степень B.
//  НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt( string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Exp(int number, int exponent)
{
    int exp = 1;
    for(int i = 0; i < exponent; i++)
    {
        exp *= number; 
    }
    return exp;
}

bool ValidateExp(int exponent)
{
    if(exponent < 0)
    {
        System.Console.WriteLine("введите значение степени болше 0");
        return false;
    }
    return true;
}

int number = ReadInt("введите число: ");
int exponent = ReadInt("введите значение степени: ");
if(ValidateExp(exponent))
{
    System.Console.WriteLine($"число {number} в степени {exponent} = {Exp(number, exponent)}");
}