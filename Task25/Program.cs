// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = DegreeNumber(number1, number2);
Console.WriteLine($"Первое число в степени второго числа равно: {result}");

int DegreeNumber (int num1, int num2)
{
    int degree = 1;
    for (int i = 1; i <= num2; i++)
    {
        degree = degree * num1;
    } 
    return degree;
}