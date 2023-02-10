// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] arr = new double[5];

void FillAndWriteArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100) + new Random().NextDouble();
        Console.Write($"{arr[i]:f3} ");
    }
}

double FindMin(double[] arr)
{
    double min = arr[0];
    foreach (double el in arr)
    {
        if (el < min)
        {
            min = el;

        }
    }
    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    foreach (double el in arr)
    {
        if (el > max)
        {
            max = el;

        }
    }
    return max;
}

FillAndWriteArr(arr);
double min = FindMin(arr);
double max = FindMax(arr);
double diff = max - min;
Console.WriteLine($" -> {diff:f3}");