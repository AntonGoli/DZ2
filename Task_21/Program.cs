//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты X и Y и Z Точки А:");
string xyz = Console.ReadLine()!;
string[] parts = xyz.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);
int zA = int.Parse(parts[2]);

Console.WriteLine("Введите координаты X и Y и Z Точки B:");
xyz = Console.ReadLine()!;
parts = xyz.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);
int zB = int.Parse(parts[2]);

double distance= Math.Sqrt(Math.Pow(xA - xB, 2)+ Math.Pow(yA - yB, 2)+Math.Pow(zA - zB, 2) );
Console.WriteLine($"Расстояние между этими точками равно {distance:F2} единиц");