//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("enter a five-digit number: ");
string number = Console.ReadLine();

int Con(string stNumber, int index1, int index2)
{
    string a = Convert.ToString(stNumber[index1]);
    string b = Convert.ToString(stNumber[index2]);
    int a1 = Convert.ToInt32(a);
    int b1 = Convert.ToInt32(b);
    int c = 0;
    
    int sum = a1 * 10 + b1;
    return sum;
}

int sum1 = Con(number, 0, 1);
int sum2 = Con(number, 4, 3);


if (sum1 == sum2)
{
    Console.WriteLine("Yes");
}

else
{
    Console.WriteLine("No");
}