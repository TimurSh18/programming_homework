﻿// Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы



double b1 = 15;
double b2 = 20;

double k1 = 6;
double k2 = 4;
//Попробовал, просто, решить эту задача математически, не знаю, что тут можно нафантазировать с помощью си шарпа.
 
// Представим, что по изначальным параметрам y = 6*x + 5 ; y = 4*x + 6 

double minusB = b1 - b2;
double findX = minusB/(k2-k1);
//Для того, чтобы найти Х - нужно приравнять прямые.


Console.Write($"Точка пересечения между прямыми y = {k1}x+{b1} и y = {k2}x+{b2} = {findX}");
//Для того, чтобы найти Х - нужно приравнять прямые.
