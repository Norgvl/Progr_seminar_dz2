// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Enter a number: ");
string stNumber = Console.ReadLine();
int sum = 0;
if (Convert.ToInt32(stNumber) < 0 )
{
    for (int i = 1; i < stNumber.Length; i++)
    {
        string b = Convert.ToString(stNumber[i]);
        int c = Convert.ToInt32(b);
        sum = sum + c;

    }
}

else
{
    for (int i = 0; i < stNumber.Length; i++)
    {
        string b = Convert.ToString(stNumber[i]);
        int c = Convert.ToInt32(b);
        sum = sum + c;

    }
}
Console.WriteLine(stNumber + " --> " + sum);
