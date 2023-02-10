// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5

Console.Clear();

int[] arr = new int[123]; 
void FillAndWriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1001);
    
    }
    Console.Write($"[{String.Join(", ", arr)}]");
}

int CountNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el >= 10 && el <= 99)
        {
            count++;
        }
    }
    return count;
}

FillAndWriteArr(arr);
int number = CountNumber(arr);
Console.Write(" -> "+ number);