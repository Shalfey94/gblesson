// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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

int[] MultiArray(int[] array)
{
    int size = array.Length % 2 != 0 ? array.Length / 2 + 1 : array.Length / 2;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i == newArr.Length - 1 && array.Length % 2 == 1)
        {
            newArr[i] = array[i];
        }
        else
        {
            newArr[i] = array[i] * array[array.Length - 1 - i];
        }    
    }
    return newArr;
}



int[] arr = CreateArrayRndInt(11, 0, 10);
PrintArray(arr);
int[] newArr = MultiArray(arr);
PrintArray(newArr);