// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("введите пятизначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

if ( number1 < 100000 && number1 > 9999)
{
   int x1 = number1 / 10000;
   int x2 = (number1 / 1000) % 10;
   int x4 = (number1 / 10) % 10;
   int x5 = number1 % 10;
//  Console.WriteLine($"{x1} {x2} {x4} {x5}");
   if ( x2 == x4 && x1 == x5)
   {
    Console.WriteLine("полиндром");
   }
   else Console.WriteLine("не является полиндромом");

}
else Console.WriteLine("введеное число не соответствует условиям");