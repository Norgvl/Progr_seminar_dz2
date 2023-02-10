// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] arr = new int[4];

void FillAndWriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
        Console.Write(arr[i]+" ");
    }
}

int CountNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            count += arr[i];

        }
    }
    return count;
}

FillAndWriteArr(arr);
int number = CountNumber(arr);
Console.WriteLine(" -> "+number);