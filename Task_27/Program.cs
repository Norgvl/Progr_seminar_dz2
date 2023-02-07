// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

int Count(int number)
{
    if (number < 0) number = number * (-1);
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number /= 10;

    }
    return sum;
}

int sum = Count(number);
Console.WriteLine(number + " --> " + sum);