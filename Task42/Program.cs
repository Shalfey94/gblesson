// Напишите программу, которая будет преобразовывать десятичное число в двоичное

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = BinaryNumber(number);
Console.WriteLine(result);

int BinaryNumber(int num)
{
    int count = 1;
    int binNum = 0;
    while(num > 0)
    {
        binNum = binNum + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return binNum;
}