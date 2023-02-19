﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();
Write("m: ");
int m = int.Parse(ReadLine());
Write("n: ");
int n = int.Parse(ReadLine());
double[,] arr = new double[m, n];
FillAndWriteArr(arr);

void FillAndWriteArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble()*10;
            Write($"{arr[i,j]:f3} ");
        }
        WriteLine();
    }
}