// Составить частотный словарь элементов двумерного
// массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// Элементы [0, 9]

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
            matrix[i, j] = matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }
return matrix;
}

int[] GetArray(int[,] MyArray)
{
    int[] Array = new int[10];
    for(int i = 0; i < MyArray.GetLength(0); i++)
    {
        for(int j = 0; j < MyArray.GetLength(1); j++)
        {
            Array[MyArray[i, j]]++;
        }
    }
    return Array;
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

int[] Result = GetArray(myMatrix);

for(int i = 0; i < Result.Length; ++i)
{
    Console.Write($"{i} : {Result[i]} |");
}
// Console.WriteLine(String.Join("|", Result)); считает, но не показывает для кого

// разница расположения ++
// int u = 9;
// int a = (u++) + 5;
// Console.WriteLine(a);
// a = (++u) + 5;
// Console.WriteLine(a);

// другой вариант решения
// Console.WriteLine("Введите количество строк");
// int zz=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int rz=Convert.ToInt32(Console.ReadLine());
// int[,] a=new int[rz,zz];
// for(int i=0;i<rz;i++){
// for(int j=0;j<zz;j++){
// a[i,j]=Random.Shared.Next(0,10);
// }
// }
// for(int i=0;i<rz;i++){
// for(int j=0;j<zz;j++){
// Console.Write("{0,3}", a[i, j]);
// }
// Console.WriteLine();
// }
// for(int g = 0; g < 10; g++)
// {
//     int count = 0;
//     for(int i = 0; i < rz; i++)
//     {
//         for(int j = 0; j < zz; j++)
//         {
//             if(a[i, j] == g)
//             {
//                 count++;
//             }
//         }
//     }
//     Console.WriteLine($"{g} встречается {count} раз");
// }