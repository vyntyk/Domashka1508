﻿/*Задача 25: Напишите цикл, который принимает на вход
 два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


Console.Clear();
Console.WriteLine("Введите число 1: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число 2: ");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {x} в степени {y} = {Math.Pow(x, y)}");