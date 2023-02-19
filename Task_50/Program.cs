// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
int s1 = new Random().Next(2,8);
int s2 = new Random().Next(2,8);
double[,] arr = new double[s1,s2];
FillAndWriteArr(arr);

Write("Введите индекс элемента через пробел: ");

string index = ReadLine();
string[] indexArr = index.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
int m = int.Parse(indexArr[0]);
int n = int.Parse(indexArr[1]);
CheckElement(arr, m, n);

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

void CheckElement(double[,] arr, int m, int n)
{
    if 
    (m >= arr.GetLength(0) 
    || n >= arr.GetLength(1)
    || m < 0
    || n < 0)
    {
        WriteLine("Такого числа нет в массиве");
    }
    else 
    {
        WriteLine($"Число с индексами [{m},{n}] = {arr[m,n]}");
    }

}