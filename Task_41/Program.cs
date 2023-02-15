//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2-> 2

//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Enter the numbers separated by spaces: ");
string stNumbers = Console.ReadLine();
int[] arr = FillArr(stNumbers);
int score = Count(arr);
Console.Write("-> "+score);
int[] FillArr(string numbers)
{
    string[] numbersArr = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[numbersArr.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(numbersArr[i]);
    }
    return array;
}

int Count(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el > 0)
        {
            count++;
        }
    }
    return count;
}