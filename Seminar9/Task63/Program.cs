//  Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6" 

int n = 12;
void PrintNamer (int number)
{

    if (number <= 0) return;
    PrintNamer (number - 1);
    Console.Write (number + " ");
}

PrintNamer(n);
