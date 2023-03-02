// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("N: ");
int N = int.Parse(Console.ReadLine());
if (N<M) 
{
    Console.WriteLine("N должно быть больше M");
    return;
}
Console.WriteLine(Sum(M,N));

int Sum(int M, int N)
{
    int sum = 0;
    if(N>=M)
    {
        sum = M;
        M++;
        return sum + Sum(M,N);

    }
    return sum;

}
