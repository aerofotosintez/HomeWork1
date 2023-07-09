﻿// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("введите количество строк:");
int ROWS = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int COLUMNS = Convert.ToInt32(Console.ReadLine());

int[,] GetRandomMatrix( int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] = Random.Shared.Next(1, 20);
        }
    }
return matrix;
}

double Average(int[,] matrix)
{
    double summa = 0;
    double average = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            
            summa += matrix[i, j];
            
        }
        average = summa / (matrix.GetLength(0));
        Console.WriteLine((String.Format($"{average:f2}\t")));
    }
    return average;    
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine();
double average = Average(myMatrix);
Console.WriteLine(average);
