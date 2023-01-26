// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнююстроку массива

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

int[,] StringReplacement(int[,] matrix)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j]; 
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
} 

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
StringReplacement(array2D);
PrintMatrix(array2D);