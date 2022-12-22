// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Cube(int n1)
{
    int counter = 1;
    while(counter <= n1)
    {
        Console.WriteLine($"{counter} | {counter * counter * counter}");
        counter++;
    }
}

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 1)
{
    Console.WriteLine("Введите положительное, целое число");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"{number} -> ");
Cube(number);