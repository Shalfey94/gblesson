// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1 = EnterNumber("Введите k1:");
double b1 = EnterNumber("Введите b1:");
double k2 = EnterNumber("Введите k2:");
double b2 = EnterNumber("Введите b2:");

var tuple = IntersectionPoint(k1, b1, k2, b2);
Console.WriteLine(tuple);

(double, double) IntersectionPoint(double numK1, double numB1, double numK2, double numB2)
{
    double xPoint = (numB2 - numB1) / (numK1 - numK2);
    double yPoint = numK1 * xPoint + numB1;
    var res = (xPoint, yPoint);
    return res;
}

int EnterNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}