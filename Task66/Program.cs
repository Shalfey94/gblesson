// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());
int result;
if (numberM < numberN)  result = SumBetweenNumbers(numberM, numberN);
else result = SumBetweenNumbers(numberN, numberM);
Console.WriteLine(result);

int SumBetweenNumbers(int m, int n)
{
    if(m > n) return 0;
    return m + SumBetweenNumbers(m + 1, n);
}