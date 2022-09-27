/* 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("Xa: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ya: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Za: ");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("Xb: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Yb: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Zb: ");
int zb = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));

int temp = (int)(distance * 100);
double newDistance = (double)temp / 100;

Console.WriteLine($"Расстояние между двумя точками в 3D ->{newDistance}");

