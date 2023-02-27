// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;

Console.Clear();
Write("Строки: ");
int m = int.Parse(ReadLine());
Write("Столбцы: ");
int n = int.Parse(ReadLine());
int[,] arr = new int[m,n];

FillAndWriteArr(arr);;
WriteLine("Строка: "+CountStr(arr));

void FillAndWriteArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1,10);
            Write($"{arr[i,j]} ");
        }
        WriteLine();
    }
}

int CountStr(int[,] arr)
{
    int min = 0;
    int minIndex = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }

        min = i == 0 ? sum: min;
        if(sum < min)
        {
            min = sum;
            minIndex = i + 1;
        } 

    }
    return minIndex;

}