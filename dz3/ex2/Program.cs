using System;

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите Координат X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Координат X2: ");
int x2 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите Координат X3: ");
int x3 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Координат Y1: ");
int y1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите Координат Y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Координат Y3: ");
int y3 = int.Parse(Console.ReadLine()); 

int [] a = {x1, x2, x3};
int [] b = {y1, y2, y3};

double Len = Math.Sqrt(Math.Pow((b[0] - a[0]), 2) + Math.Pow((b[1] - a[1]), 2) + Math.Pow((b[2] - a[2]), 2));

// double Len = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y2), 2));

Console.WriteLine("Расстояние между точками = "+ Len);