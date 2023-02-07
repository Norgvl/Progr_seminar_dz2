// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Enter a number: ");
string stNumber = Console.ReadLine();

int Count(string stNumber, int index)
{
int sum = 0;
for (int i = index; i < stNumber.Length; i++)
    {
        string a = Convert.ToString(stNumber[i]);
        int b = Convert.ToInt32(a);
        sum = sum + b;

    }
    return sum;
}

if (Convert.ToInt32(stNumber) < 0 )
{
   int sum = Count(stNumber, 1);
   Console.WriteLine(stNumber + " --> " + sum);
}

else
{
    int sum = Count(stNumber, 0);
    Console.WriteLine(stNumber + " --> " + sum);
}

