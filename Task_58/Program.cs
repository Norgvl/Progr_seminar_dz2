// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Console.Clear();
Write("Строки перовй: ");
int m = int.Parse(ReadLine());
Write("Столбцы первой/Строки второй:");
int n = int.Parse(ReadLine());
Write("Столбцы второй: ");
int k = int.Parse(ReadLine());

int[,] arr1 = new int[m,n];
int[,] arr2 = new int[n,k];

FillAndWriteArr(arr1);
WriteLine();
FillAndWriteArr(arr2);
WriteLine();
MatrixProduct(arr1, arr2);

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

void MatrixProduct(int[,] arr1, int[,] arr2)
{
    int[,] matrix = new int[arr1.GetLength(0), arr2.GetLength(1)];
     for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < arr2.GetLength(0); r++)
            {
                sum += arr1[i,r]*arr2[r,j];
            }
            matrix[i,j] = sum;
            Write(matrix[i,j]+" ");
        }
        WriteLine();
    }
}