Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSum(a)}");


int GetSum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
            num = num / 10;
    }
    return sum;
}
