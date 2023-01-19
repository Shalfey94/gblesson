// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибонначи: 0 и 1.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = FiboncciArray(number);
PrintArray(arr);



int[] FiboncciArray(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-1] + array[i-2];
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

