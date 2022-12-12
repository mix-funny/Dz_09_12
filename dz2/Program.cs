Console.Clear();
Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

int Pow(int a, int b)
{
    int num = 1;
    int result = 1;
    for(num = 1; num <= b; num++ )
    {
        result = result * a;
    }
    return result;
}
int result = Pow(a, b);
Console.WriteLine($"Число {a} возведенное в степень {b} = {result}");