/**Задайте двумерный массив. Напишите программу, которая 
 упорядочит по убыванию элементы каждой строки двумерного
  массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2**/

// int temp = matrix[0, j];
//         matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
//         matrix[matrix.GetLength(0) - 1, j] = temp;

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

// int[,] Array = new int[rows,columns];
// int[,] NewArray = new int[Array.GetLength(0),Array.GetLength(1)];
// for(int j = 0; j < Array.GetLength(1); j++)
// {
//     for(int i = 0; i < Array.GetLength(0); i++)
//     {
        
//         if(Array[i+1,j] < Array[i,j])
//         {
            
//             NewArray[i,j] = Array[i+1,j];
            
//         }
        //  else
        //  {
        //     NewArray[i,j] = Array[i,j];
        //  }
//     }
// }

int[,] GetPositionMin(int[,] Matrix)
{
    int iPositionMin = 0;
    int jPositionMin = 0;
    int min = Matrix[0,0];
    for(int j = 0; j < Matrix.GetLength(1); j++)
        for(int i = 0; i < Matrix.GetLength(0); i++)
        {
            if(Matrix[i, j] < min)
            {
                min = Matrix[i,j];
                iPositionMin = i;
                jPositionMin = j;
            }
        }
    int[,] arrayPair = new int [,] {iPositionMin,jPositionMin};
    return arrayPair;
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

Console.WriteLine();
int[,] Matr = GetRandomMatrix(ROWS, COLUMNS);
int[] array = GetPositionMin(Matr);
PrintMatrix(Matr);
Console.WriteLine();

// int[,] MatrReduced = RemoveRowAndColumn(Matr, array);
// PrintMatrix(MatrReduced);

        
