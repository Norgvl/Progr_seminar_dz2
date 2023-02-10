// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21

Console.Clear();
Console.Write("Enter the array size: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

void FillAndWriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);

    }
    Console.Write($"[{String.Join(", ", arr)}]");
}

int[] CountNewArr(int[] arr)
{
    int[] list = new int[arr.Length / 2];
    if (arr.Length % 2 == 0)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            list[i] = arr[i] * arr[arr.Length - 1 - i];

        }
    }

    if (arr.Length % 2 != 0)
    {
        int i = 0;
        list = new int[arr.Length / 2 + 1];
        
        while (i < arr.Length / 2 )
        {
            list[i] = arr[i] * arr[arr.Length - 1 - i];
            i++;

        }
        list[i] = arr[i];

    }
    return list;
}
FillAndWriteArr(arr);
int[] mas = CountNewArr(arr);
Console.WriteLine($" -> [{String.Join(", ", mas)}]");