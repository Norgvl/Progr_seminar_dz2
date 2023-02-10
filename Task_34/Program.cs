// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] arr = new int[4];

void FillAndWriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);

    }
    Console.Write($"[{String.Join(", ", arr)}]");
}

int CountNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            count++;

        }
    }
    return count;
}

FillAndWriteArr(arr);
int number = CountNumber(arr);
Console.WriteLine(" -> "+number);