// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

Console.Clear();
Write("Строки: ");
int m = int.Parse(ReadLine());
Write("Столбцы: ");
int n = int.Parse(ReadLine());
int[,] arr = new int[m,n];

FillAndWriteArr(arr);
WriteLine();
ChangeArr(arr);

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

void ChangeArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int index = j;
            int temp = arr[i,j];
            for(int r = j; r < arr.GetLength(1); r++)
            {
                if (arr[i,j] < arr[i,r])
                {
                    arr[i,j] = arr[i,r];
                    index = r;
                
                }
            }
            arr[i,index] = temp;
            Write(arr[i,j]+ " ");
        }
        WriteLine();
    }

}