﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int S = int.Parse(Console.ReadLine());

int digit2 = S /10 %10;

Console.WriteLine($"Вторая цифра числа {digit2}");

