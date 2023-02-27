// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] arr = new int[4, 4];
FillArr(arr);
PrintArr(arr);

void FillArr(int[,] arr)
{
    int a = 10;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        arr[0, j] = a;
        a++;
    }
    for (int i = 1; i < arr.GetLength(1); i++)
    {
        arr[i, 3] = a;
        a++;
    }
    for (int j = 2; j >= 0; j--)
    {
        arr[3, j] = a;
        a++;
    }
    for (int i = 2; i > 0; i--)
    {
        arr[i, 0] = a;
        a++;
    }
    for (int j = 1; j < arr.GetLength(0) - 1; j++)
    {
        arr[1, j] = a;
        a++;
    }
    for (int j = 2; j > 0; j--)
    {
        arr[2, j] = a;
        a++;
    }

}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
