// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine(" ]");
    }
}

int RowSumMinimum(int[,] matrix)
{
    
    
    int row = 1;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumCurrent = 0;
        int sumPrevious = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumCurrent+= matrix[i,j];
            sumPrevious += matrix[i-1,j];
        } 
        if(sumCurrent < sumPrevious ) 
        {
            row = i + 1;
        }
    }
    return row;
}

int[,] array2D = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2D);
int rowMinimum = RowSumMinimum(array2D);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowMinimum} строка");