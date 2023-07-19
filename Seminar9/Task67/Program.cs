// Напишите программу, которая будет принимать на вход
//  число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 453;
int SummaNamber(int summa)
{
    if(summa <= 0) return 0;
    return SummaNamber(summa / 10) + (summa % 10);
    
    // result += number % 10;
    // number = number / 10;
}

Console.Write($"сумма всех цифр в числе {number} = {SummaNamber(number)}");