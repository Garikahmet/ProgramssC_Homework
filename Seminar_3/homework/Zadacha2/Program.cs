﻿/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */ 

double ShowDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return distance;
}
Console.WriteLine("Введи X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = ShowDistance(x1, y1, x2, y2, z1, z2);
Console.WriteLine(distance);