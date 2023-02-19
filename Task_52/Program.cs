// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();
int s1 = new Random().Next(3,7);
int s2 = new Random().Next(3,7);
double[,] arr = new double[s1,s2];
FillAndWriteArr(arr);
WriteLine();
double[] arr1 = FindArMean(arr);
PrintArr(arr1);

void FillAndWriteArr(double[,] arr)
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

double[] FindArMean(double[,] arr)
{
    double[] nums = new double[arr.GetLength(1)];
     for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i,j];
        }
        nums[j] = sum / arr.GetLength(0); 
    }
    return nums;
}

void PrintArr(double[] arr)
{
    Console.Write("Среднее арифметическое каждого стоблца: ");
    foreach(double el in arr)
    {
        Write($"{el:f1} ");
    }
}