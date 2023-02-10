// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21

Console.Clear();
Console.Write("Enter the array elements separated by spaces: ");
string elements = Console.ReadLine();

int[] FillArr(string elements)
{
    string[] stArr = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[stArr.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(stArr[i]);

    }  
    return array;

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
int[] arr = FillArr(elements);
int[] mas = CountNewArr(arr);
Console.WriteLine($"-> [{String.Join(", ", mas)}]");