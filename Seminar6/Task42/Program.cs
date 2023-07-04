// Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string a = "" ;
while(number != 0)
{
    int i = number % 2;
    number /= 2;
    a = i + a; 
    // a+=i => a=a+i
}
Console.WriteLine(a);