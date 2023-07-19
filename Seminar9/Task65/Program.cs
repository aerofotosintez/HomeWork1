// Задайте значения M и N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int m = 4;
int n = 8;

void PrintNamberDiapazon (int namberM,int namberN )
{
    if(namberN <= namberM - 1) return;
    PrintNamberDiapazon(namberM, namberN - 1);
    Console.Write(namberN + " ");
}
PrintNamberDiapazon(m,n);