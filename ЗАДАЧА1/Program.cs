﻿// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());

if(k1==k2 && b1!=b2)
{
    Console.WriteLine("Две прямые параллельны");
}

else if(k1==k2 && b1==b2)
{
    Console.WriteLine("Две прямые совпадают");
}

else
{
double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;


Console.WriteLine($"Две прямые пересекаются в точке с координатами X:{x}, Y:{y}");
}