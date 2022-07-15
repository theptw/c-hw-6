﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1,
// b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// X = (b2-b1)/(k1-k2)

Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());


void Calc(double K1, double B1, double K2, double B2)
{
    double x = (B2-B1)/(K1-K2);
    double y = K1 * x + B1;
    
    Console.WriteLine($"Координаты точки пересечиния прямых [{x};{y}]");
}


Calc(k1,b1,k2,b2);







