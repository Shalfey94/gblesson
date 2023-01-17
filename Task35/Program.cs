// Задайте одномерный массив из 123 случайных чисел.
// Найдите кол-во элементов массива, значения которых лежат в отрезке [10, 99].

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next();
    }
    return array;
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 & array[i] < 100)
        count++;
    }
    return count;
}


int[] arr = CreateArrayRndInt(123);
int result = CountNumber(arr);
Console.WriteLine($"{result} элементов массива лежат в отрезке [10, 99]");
