// Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumber (int number)
{

    if (number <= 0) return;
    Console.Write (number + " ");
    PrintNumber (number - 1);
    
}

PrintNumber(n);
