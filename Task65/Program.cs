// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите первое натуральное число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber > firstNumber) NaturalNumber(firstNumber, secondNumber);
else NaturalNumber(secondNumber, firstNumber);

void NaturalNumber(int firstNum, int secondNum)
{
    if(secondNum == firstNum - 1) return;
    NaturalNumber(firstNum, secondNum - 1);
    Console.Write($"{secondNum} ");
}