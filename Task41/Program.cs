// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = EnterNumber("Укажите кол-во чисел, которое вы хотите ввести:");
int[] arr = InsertNumberArray(count);
PrintArray(arr);
int result = PositiveDigit(arr);
Console.WriteLine("\n" + $"Количество положительных чисел равно: {result}");

int PositiveDigit(int[] array)
{
    int countDigit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        countDigit++;
    }
    return countDigit;
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


int[] InsertNumberArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = EnterNumber("Введите число:"); 
    }
    return array;
}

int EnterNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}