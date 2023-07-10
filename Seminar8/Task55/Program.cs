// Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 

Console.WriteLine("введите количество строк:");
int ROWS = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int COLUMNS = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] GetRandomMatrix(int rows, int columns)
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

int[,] SwapRowsAndColumns(int[,] matrix)
{   
    int[,] myMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            myMatrix[j, i] = matrix[i, j];
        }
    }
    return myMatrix;
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

int[,] myMatrixNew = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrixNew);
Console.WriteLine();

int[,] NewMatrix = SwapRowsAndColumns(myMatrixNew);
PrintMatrix(NewMatrix);