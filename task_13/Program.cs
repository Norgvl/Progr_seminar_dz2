/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.Clear();
string a = Console.ReadLine();
if (a.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else{
Console.WriteLine($"{a} -> {a[2]}");
}

/*
// Делала до просмотра разбора дз в конце семинара, не зная про обращение к строке:

Console.Clear();
string numString = Console.ReadLine();
int num = int.Parse(numString);
int length = numString.Length;

if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int count = 10;
    for (int i = 2; i <= length - 1; i++)
    {
        count = count * 10;

    }

    int aFirst = num / count;
    int aSecond = (num / (count / 10)) - (aFirst * 10);
    int aThird = (num / (count / 100)) - (aFirst * 100) - (aSecond * 10);

    Console.WriteLine($"{numString} -> {aThird}");


}
*/