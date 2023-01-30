



Console.WriteLine("Введите натуральное число:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число:");
int numN = Convert.ToInt32(Console.ReadLine());
int result = DegreeNumber(numM, numN);
Console.WriteLine(result);

int DegreeNumber(int n, int m)
{
    if(m == 0) return 1;
    return n *  DegreeNumber(n, m - 1);
}