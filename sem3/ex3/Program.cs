using System;

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве


Console.Clear();
Console.WriteLine("Введите Координат X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Координат У1: ");
int y1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите Координат X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Координат Y2: ");
int y2 = int.Parse(Console.ReadLine()); 

double Len = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

Console.WriteLine("Расстояние между точками = "+ Len);

