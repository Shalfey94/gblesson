// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


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

(int min, int row, int column) MinElementIndex(int[,] matrix)
{
    int min = matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j])
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    return (min, minI, minJ);
}

int[,] DeleteRowColumnCross(int[,] matrix, int iMin, int jMin)
{
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        if (m == iMin) m++;
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if(n == jMin) n++;
            resultMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
        n = 0;
    }
    return resultMatrix;
}

int[,] array2D = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(array2D);
var minElement = MinElementIndex(array2D);
Console.WriteLine(minElement);
int[,] resultArray2D = DeleteRowColumnCross(array2D, minElement.row, minElement.column);
PrintMatrix(resultArray2D);