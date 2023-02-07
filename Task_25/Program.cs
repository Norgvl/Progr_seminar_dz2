//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Enter a number: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter a power: ");
int B = int.Parse(Console.ReadLine());
int c = A;

Console.Write(A);
for (int i = 1; i < B; i++)
{
        A = A * c;
}

Console.Write($" --> {A}");