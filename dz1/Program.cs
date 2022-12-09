Console.Clear();
int[] x = new int[8];
int[] GetNewArr(int[] a)
{
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите число: ");
    a[i] = int.Parse(Console.ReadLine()!);
}
return a;
}
void PrintR(int[] arr)
{
    for(int i = 0; i < 8; i++)
    {
        Console.Write(arr[i] + " ");

    }
}
PrintR(GetNewArr(x));
