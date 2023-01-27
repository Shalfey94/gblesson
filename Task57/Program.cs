// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int[,] CreateDictionaryFromArray(int[] array)
{
    int[,] dictionaryMatrix = new int[array.Length, 2];
    int currentValue = array[0];
    dictionaryMatrix[0, 0] = currentValue;
    dictionaryMatrix[0, 1] = 1;
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {

        if (array[i] == currentValue)
        {
            dictionaryMatrix[count, 1]++;
        }
        else
        {
            count++;
            dictionaryMatrix[count, 0] = array[i];
            dictionaryMatrix[count, 1]++;
            currentValue = array[i];
        }
    }
    return dictionaryMatrix;
}

int[,] array2D = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(array2D);
int[] array = MatrixToArray(array2D);
Array.Sort(array);
PrintArray(array);
int[,] dictionaryMatr = CreateDictionaryFromArray(array);
Console.WriteLine();
PrintMatrix(dictionaryMatr);





