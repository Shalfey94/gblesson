// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if(num > 99 && num < 1000)
// {
//     int result = (num - num / 100 * 100) / 10;
//     Console.WriteLine($"{num} -> {result}");
// }
// else
// {
//     Console.WriteLine("Некорректный ввод");
// }

int SecondDigit(int num)
{
    int result = (num - num / 100 * 100) / 10;
    return result;
}

if(number > 99 && number < 1000)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"{number} -> {secondDigit}");
}
else
{
    Console.WriteLine("Некорректный ввод");
}