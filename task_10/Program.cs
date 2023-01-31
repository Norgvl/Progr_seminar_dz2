/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
int a = new Random().Next(100, 1000);

int[] Splitting(int n)
{
    int[] arr = new int[3];
    int a1 = n / 10;     // десятки
    int a2 = n % 100;     // единицы
    arr[0] = n / 100;     // сотни
    arr[1] = a1 - arr[0] * 10; // десятки
    arr[2] = a2 - arr[1] * 10;  // единицы
    return arr;

}

int[] split = Splitting(a);
Console.WriteLine(a + " " + split[0] + " " + split[1] + " " + split[2]);
Console.WriteLine(split[1]);
