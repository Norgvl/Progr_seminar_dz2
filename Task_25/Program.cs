//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Enter a number: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter a power: ");
int B = int.Parse(Console.ReadLine());

void CountPow(double A, int B)
{
    Console.Write(A);
    double c = A;
    for (int i = 1; i < B; i++)
    {
        A = A * c;
    }

    Console.Write($" --> {A}");
}

CountPow(A,B);