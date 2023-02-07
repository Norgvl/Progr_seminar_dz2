//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
int[] arr = new int[8];
void FillAndPrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i >= 1) Console.Write(", ");
        arr[i] = new Random().Next(-10, 10);
        Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

FillAndPrintArr(arr);
