// Задайте двумерный массив.
// Напишите программу которая заменяет строки на столбцы.
// В случае если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine(" ]");
    }
}

int[,] RowToColumnReplacement(int[,] matrix)
{
    int temp = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i]; 
            matrix[j, i] = temp;
        }
    }
    return matrix;
} 

int[,] array2D = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
if(array2D.GetLength(0) == array2D.GetLength(1))
{
    RowToColumnReplacement(array2D);
    PrintMatrix(array2D);
} 
else Console.WriteLine("Количество строк и столбцов не равно");
