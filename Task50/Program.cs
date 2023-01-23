// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");
            else Console.Write($"{matrix[i, j], 4}  ");
        }
        Console.WriteLine("]");
    }
}

int EnterNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckExistElement(int[,]matrix, int row, int column)
{
    return row < matrix.GetLength(0) && column < matrix.GetLength(1);   
}

int numRow = EnterNumber("Введите индекс строку:");
int numColumn = EnterNumber("Введите индекс столбца:");
int[,] array2D = CreateMatrixRndInt(5, 5, 0, 100);
PrintMatrix(array2D);
Console.WriteLine(CheckExistElement(array2D, numRow, numColumn) 
    ? array2D[numRow, numColumn] 
    : "Такого элемента в массиве нет");