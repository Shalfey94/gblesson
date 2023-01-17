// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble()*(max - min) + min;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double MaxNumber(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] arr = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(arr);
double maxNum = MaxNumber(arr);
double minNum = MinNumber(arr);
double result = maxNum - minNum;
Console.WriteLine("\n" + $"Разницу между максимальным и минимальным элементов массива равна: {result}");