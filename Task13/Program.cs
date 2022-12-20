// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    int result = (num % 100) % 10;
    return result;
}

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа -> {thirdDigit}");

}
else
{
    Console.WriteLine("Третьей цифры нет");
}