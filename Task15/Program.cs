// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsHoliday(int num)
{
    return num == 6 || num == 7;
}
if (number > 0 && number < 8)
{
    Console.WriteLine(IsHoliday(number) ? "да" : "нет");
}
else
{
    Console.WriteLine("Некорректный ввод");
}