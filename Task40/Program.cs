// Напишите программу, которая проинимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( TriangleExist(numberA, numberB, numberC) ? "Треугольник существует" : "Треугольника не существует");



bool TriangleExist (int numA, int numB, int numC)
{
    if(numA < numB + numC && numB < numA + numC && numC < numA + numB) 
    {
        return true;
    }
    else
    {
        return false;
    }
}
