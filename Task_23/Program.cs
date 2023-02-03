// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine());
int n = N;
int sign = 1;
if (N < 0)
{
    n = N * (-1);
    sign = -1;
}
else if (N == 0)
{
    Console.WriteLine("0");
    return;
}

double[] arr = new double[n];

void Count(double[] arr, int s)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double a = i * s + 1 * s;
        arr[i] = Math.Pow(a, 3);
        
    }
    
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");

    }

}

Count(arr, sign);
PrintArray(arr); 