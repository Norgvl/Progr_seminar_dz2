// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.Write("Enter A(x): ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Enter A(y): ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Enter A(z): ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Enter B(x): ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Enter B(y): ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Enter B(z): ");
double z2 = double.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"d = {dist:f2}");